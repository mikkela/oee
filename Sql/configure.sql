BEGIN TRANSACTION
DECLARE @machineID int
INSERT INTO MachineConfiguration VALUES (1, '20C');
SET @machineID = @@identity
INSERT INTO ProductionStop VALUES (1, 'Omstilling', 0, null);
INSERT INTO AvailableProductionStops VALUES (@machineID, @@identity, 1)
INSERT INTO ProductionStop VALUES (1, 'Manglende Mandskab', 0, null);
INSERT INTO AvailableProductionStops VALUES (@machineID, @@identity, 2)
INSERT INTO ProductionStop VALUES (1, 'Vedligehold', 0, null);
INSERT INTO AvailableProductionStops VALUES (@machineID, @@identity, 3)
INSERT INTO ProductionStop VALUES (1, 'Møder', 0, null);
INSERT INTO AvailableProductionStops VALUES (@machineID, @@identity, 4)
INSERT INTO ProductionStop VALUES (1, 'Opstart', 0, null);
INSERT INTO AvailableProductionStops VALUES (@machineID, @@identity, 5)
INSERT INTO ProductionStop VALUES (1, 'Nedlukning', 0, null);
INSERT INTO AvailableProductionStops VALUES (@machineID, @@identity, 6)
INSERT INTO ProductionStop VALUES (1, 'Andet', 0, null);
INSERT INTO AvailableProductionStops VALUES (@machineID, @@identity, 7)
INSERT INTO ProductionStop VALUES (1, 'Form', 0, null);
INSERT INTO AvailableProductionStops VALUES (@machineID, @@identity, 8)
INSERT INTO ProductionStop VALUES (1, 'Robot', 0, null);
INSERT INTO AvailableProductionStops VALUES (@machineID, @@identity, 9)
INSERT INTO ProductionStop VALUES (1, 'Stans', 0, null);
INSERT INTO AvailableProductionStops VALUES (@machineID, @@identity, 10)
INSERT INTO ProductionStop VALUES (1, 'Maskine', 0, null);
INSERT INTO AvailableProductionStops VALUES (@machineID, @@identity, 11)
INSERT INTO ProductionStop VALUES (1, 'Presse', 0, null);
INSERT INTO AvailableProductionStops VALUES (@machineID, @@identity, 12)
INSERT INTO ProductionStop VALUES (1, 'Køletunnel', 0, null);
INSERT INTO AvailableProductionStops VALUES (@machineID, @@identity, 13)
INSERT INTO ProductionStop VALUES (1, 'Kasseret skud', 0, null);
INSERT INTO AvailableProductionStops VALUES (@machineID, @@identity, 14)
INSERT INTO ProductionStop VALUES (1, 'Vakuum', 0, null);
INSERT INTO AvailableProductionStops VALUES (@machineID, @@identity, 15)

INSERT INTO ProductionTeam VALUES (1, NULL, 'Daghold');
INSERT INTO ProductionTeam VALUES (1, NULL, 'Aftenhold');
INSERT INTO ProductionTeam VALUES (1, NULL, 'Nathold');
COMMIT
