using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;

using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;

namespace Mikadocs.OEE.Repository.Test
{
    [TestFixture]
    public class ProductionQueryRepositoryTest
    {
        private RepositoryFactory factory;
        
        private ProductionTeam team1;
        private ProductionTeam team2;
        private ProductionTeam team3;

        [SetUp()]
        public void SetUp()
        {
            factory = new RepositoryFactory(); ;

            team1 = new ProductionTeam("Daghold");
            team2 = new ProductionTeam("Nathold");
            team3 = new ProductionTeam("Test");
            using (IEntityRepository<ProductionTeam> repository = factory.CreateEntityRepository<ProductionTeam>())
            {
                repository.Save(team1);
                repository.Save(team2);
                repository.Save(team3);
            }
        }

        [Test]
        public void QueryOverDateRange()
        {
            Production productionA = new Production("Machine", new ProductNumber("A"), new OrderNumber("AAAA"), 1000, 100);
            Production productionB = new Production("Machine", new ProductNumber("B"), new OrderNumber("BBBB"), 1000, 100);
            Production productionC = new Production("Machine", new ProductNumber("C"), new OrderNumber("CCCC"), 1000, 100);

            Save<Production>(new [] { productionA, productionB, productionC });
            
            ProductionShift shiftA = productionA.AddProductionShift(team1, new DateTime(2009, 1, 12));
            Save<ProductionShift>(new [] { shiftA });

            Save<Production>(new [] { productionB });
            
            ProductionShift shiftB1 = productionB.AddProductionShift(team1, new DateTime(2009, 1, 12));            
            Save<ProductionShift>(new [] { shiftB1 });

            ProductionShift shiftB2 = productionB.AddProductionShift(team1, new DateTime(2009, 1, 13));           
            Save<ProductionShift>(new [] { shiftB2 });
            
            Save<Production>(new [] { productionC });

            ProductionShift shiftC = productionC.AddProductionShift(team1, new DateTime(2009, 1, 13));
            Save<ProductionShift>(new [] { shiftC });

            using (IProductionQueryRepository repository = factory.CreateProductionQueryRepository())
            {
                foreach (DateTime start in new DateTime[] { new DateTime(2009, 1, 11), new DateTime(2009, 1, 12), new DateTime(2009, 1, 13), new DateTime(2009, 1, 14), new DateTime(2009, 1, 15) })
                {
                    for (int i = 0; i < 6; i++)
                    {
                        DateTime end = start.AddDays(0);

                        Assert.That(repository.LoadProductions(new ProductionQuery()
                                        .AddDateRange(start, end)),
                            Is.EquivalentTo(GetExpectedResults(new [] { productionA, productionB, productionC }, new Pair<DateTime, DateTime>(start, end))));

                    }

                }
            }
        }

        [Test]
        public void QueryOverMachine()
        {
            Production productionA = new Production("MachineA", new ProductNumber("A"), new OrderNumber("AAAA"), 1000, 100);
            Production productionB = new Production("MachineB", new ProductNumber("B"), new OrderNumber("BBBB"), 1000, 100);
            Production productionC = new Production("MachineA", new ProductNumber("C"), new OrderNumber("CCCC"), 1000, 100);

            Save<Production>(new Production[] { productionA, productionB, productionC });

            using (IProductionQueryRepository repository = factory.CreateProductionQueryRepository())
            {
                foreach (string machine in new string[] { "MachineA", "MachineB", "MachineC" })
                {
                    Assert.That(repository.LoadProductions(new ProductionQuery()
                            .AddMachine(machine)),
                        Is.EquivalentTo(GetExpectedResults(new Production[] { productionA, productionB, productionC }, machine)));                    

                }
            }
        }

        [Test]
        public void QueryOverProductNumber()
        {
            Production productionA = new Production("Machine", new ProductNumber("A"), new OrderNumber("AAAA"), 1000, 100);
            Production productionB = new Production("Machine", new ProductNumber("B"), new OrderNumber("BBBB"), 1000, 100);
            Production productionC = new Production("Machine", new ProductNumber("A"), new OrderNumber("CCCC"), 1000, 100);

            Save<Production>(new Production[] { productionA, productionB, productionC });

            using (IProductionQueryRepository repository = factory.CreateProductionQueryRepository())
            {
                foreach (ProductNumber product in new ProductNumber[] { new ProductNumber("A"), new ProductNumber("B"), new ProductNumber("C") })
                {
                    Assert.That(repository.LoadProductions(new ProductionQuery()
                            .AddProduct(product)),
                        Is.EquivalentTo(GetExpectedResults(new Production[] { productionA, productionB, productionC }, product)));

                }
            }
        }

        [Test]
        public void QueryOverShiftsInADateRange()
        {
            Production production = new Production("Machine", new ProductNumber("P1"), new OrderNumber("O1"), 1000, 100);

            Save<Production>(new [] { production });

            ProductionShift shift1 = production.AddProductionShift(team1, new DateTime(2009, 6, 1));
            Save<ProductionShift>(new [] { shift1 });

            ProductionShift shift2 = production.AddProductionShift(team1, new DateTime(2009, 6, 2));
            Save<ProductionShift>(new [] { shift2 });

            ProductionShift shift3 = production.AddProductionShift(team1, new DateTime(2009, 6, 3));
            Save<ProductionShift>(new [] { shift3 });

            Save<Production>(new Production[] { production });
            using (IProductionQueryRepository repository = factory.CreateProductionQueryRepository())
            {
                Pair<DateTime, DateTime>[] dateRanges = new Pair<DateTime, DateTime>[]
                                                            {
                                                                new Pair<DateTime, DateTime>(new DateTime(2009, 5, 30), new DateTime(2009, 5, 31)),
                                                                new Pair<DateTime, DateTime>(new DateTime(2009, 5, 30), new DateTime(2009, 6, 5) ),
                                                                new Pair<DateTime, DateTime>(new DateTime(2009, 6, 4 ), new DateTime(2009, 6, 5) ),
                                                                new Pair<DateTime, DateTime>(new DateTime(2009, 5, 30), new DateTime(2009, 6, 2 )),
                                                                new Pair<DateTime, DateTime>(new DateTime(2009, 6, 2 ), new DateTime(2009, 6, 4) ), 
                                                                new Pair<DateTime, DateTime>(new DateTime(2009, 6, 2 ), new DateTime(2009, 6, 2) ) 
                                                            };
                for(int i = 0; i < dateRanges.Length; i++)
                {
                    ProductionQuery query = new ProductionQuery();
                    query = query.AddDateRange(dateRanges[i].First, dateRanges[i].Second);

                    List<Production> productions = new List<Production>(repository.LoadProductions(query));

                    if (i == 0 || i == 2)
                        Assert.AreEqual(0, productions.Count);
                    else
                        Assert.AreEqual(1, productions.Count);

                    if (productions.Count == 1)
                    {
                        List<ProductionShift> shifts = new List<ProductionShift>(productions[0].Shifts);
                        if (i == 1)
                        {
                            Assert.AreEqual(3, shifts.Count);
                            Assert.AreEqual(new DateTime(2009, 6, 1), shifts[0].ProductionStart.Date);
                            Assert.AreEqual(new DateTime(2009, 6, 2), shifts[1].ProductionStart.Date);
                            Assert.AreEqual(new DateTime(2009, 6, 3), shifts[2].ProductionStart.Date);
                        }
                        if (i == 3)
                        {
                            Assert.AreEqual(2, shifts.Count);
                            Assert.AreEqual(new DateTime(2009, 6, 1), shifts[0].ProductionStart.Date);
                            Assert.AreEqual(new DateTime(2009, 6, 2), shifts[1].ProductionStart.Date);                            
                        }
                        if (i == 4)
                        {
                            Assert.AreEqual(2, shifts.Count);
                            Assert.AreEqual(new DateTime(2009, 6, 2), shifts[0].ProductionStart.Date);
                            Assert.AreEqual(new DateTime(2009, 6, 3), shifts[1].ProductionStart.Date);
                        }
                        if (i == 5)
                        {
                            Assert.AreEqual(1, shifts.Count);
                            Assert.AreEqual(new DateTime(2009, 6, 2), shifts[0].ProductionStart.Date);                           
                        }
                    }
                }
            }
        }

        [Test]
        public void QueryOverLegsAtTeams()
        {
            Production production = new Production("Machine", new ProductNumber("P1"), new OrderNumber("O1"), 1000, 100);

            Save<Production>(new Production[] { production });

            ProductionShift shift1 = production.AddProductionShift(team1, new DateTime(2009, 6, 1));
            Save<ProductionShift>(new [] { shift1 });

            ProductionShift shift2 = production.AddProductionShift(team2, new DateTime(2009, 6, 1));
            Save<ProductionShift>(new [] { shift2 });

            ProductionShift shift3 = production.AddProductionShift(team1, new DateTime(2009, 6, 2));
            Save<ProductionShift>(new [] { shift3 });

            Save<Production>(new Production[] { production });
            using (IProductionQueryRepository repository = factory.CreateProductionQueryRepository())
            {
                ProductionTeam[] teams = new ProductionTeam[]
                                                            {
                                                                team1, team2, team3
                                                            };
                for (int i = 0; i < teams.Length; i++)
                {
                    ProductionQuery query = new ProductionQuery();
                    query = query.AddTeam(teams[i]);

                    List<Production> productions = new List<Production>(repository.LoadProductions(query));

                    if (i == 2)
                        Assert.AreEqual(0, productions.Count);
                    else
                        Assert.AreEqual(1, productions.Count);

                    if (productions.Count == 1)
                    {
                        var shifts = new List<ProductionShift>(productions[0].Shifts);
                        if (i == 0)
                        {
                            Assert.AreEqual(2, shifts.Count);

                            Assert.AreEqual(team1, shifts[0].Team);
                            Assert.AreEqual(team1, shifts[1].Team);
                        }
                        if (i == 1)
                        {
                            Assert.AreEqual(1, shifts.Count);
                            Assert.AreEqual(team2, shifts[0].Team);                            
                        }                        
                    }
                }
            }
        }

        private void Save<T>(IEnumerable<T> entities) where T:EntityObject
        {
            foreach (T entity in entities)
            {
                using (IEntityRepository<T> repository = factory.CreateEntityRepository<T>())
                {
                    repository.Save(entity);
                }
            }
        }

        private List<Production> GetExpectedResults(IEnumerable<Production> productions, Pair<DateTime, DateTime> dateRange)
        {
            List<Production> result = new List<Production>();
            foreach (Production production in productions)
            {
                if (dateRange.First <= production.ProductionStart.Date &&
                    production.ProductionStart.Date <= dateRange.Second)
                    result.Add(production);

            }

            return result;
        }

        private List<Production> GetExpectedResults(IEnumerable<Production> productions, string machine)
        {
            List<Production> result = new List<Production>();
            foreach (Production production in productions)
            {
                if (production.Machine.Equals(machine))
                    result.Add(production);
            }

            return result;
        }

        private List<Production> GetExpectedResults(IEnumerable<Production> productions, ProductNumber productNumber)
        {
            List<Production> result = new List<Production>();
            foreach (Production production in productions)
            {
                if (production.Product.Equals(productNumber))
                    result.Add(production);
            }

            return result;
        }
    }
}
