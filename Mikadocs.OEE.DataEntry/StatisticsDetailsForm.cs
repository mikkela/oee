using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mikadocs.OEE.DataEntry
{
    public partial class StatisticsDetailsForm : Form
    {
        private ProductionStatisticsValidator validator;

        public StatisticsDetailsForm(ProductionStatisticsValidator validator)
        {
            InitializeComponent();

            this.validator = validator;
            SetTexts();
        }

        public DateTime UpdateTime
        {
            get
            {
                return dtUpdateDate.Value.Date.Add(ucUpdateTime.Value);
            }
        }

        public long ProductionCounter
        {
            get { return long.Parse(txtProductionCounter.Text); }
        }

        public long DiscardedItems
        {
            get { return long.Parse(txtDiscarded.Text); }
        }

        private void OnTextBoxKeyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void OnValidatingUpdateTime(object sender, CancelEventArgs e)
        {
            if (!IsUpdateTimeValid(UpdateTime))
            {
                NotifyOfInvalidUpdateTime();
                CancelEvent(e);
            }
        }

        private void OnValidatingProductionCounter(object sender, CancelEventArgs e)
        {
            if (IsProductionCounterValid(ProductionCounter))
                return;

            NotifyOfInvalidProductionCounter();
            CancelEvent(e);
        }

        private void OnValidatingDiscardedItems(object sender, CancelEventArgs e)
        {
            if (IsDiscardedItemsValid(DiscardedItems))
                return;

            NotifyOfInvalidDiscardedMachineItems();
            CancelEvent(e);
        }

        private bool IsUpdateTimeValid(DateTime updateTime)
        {
            return validator.ValidateUpdateTime(updateTime);
        }

        private bool IsProductionCounterValid(long productionCounter)
        {
            return validator.ValidateProductionCounter(productionCounter);
        }

        private bool IsDiscardedItemsValid(long discardedItems)
        {
            return validator.ValidateDiscardedItems(discardedItems);
        }

        private void ClearAnyPreviousNotifications()
        {
            errorProvider.Clear();
        }

        private void NotifyOfInvalidUpdateTime()
        {
            errorProvider.SetError(dtUpdateDate, Strings.InvalidUpdateTime);
        }

        private void NotifyOfInvalidProductionCounter()
        {
            errorProvider.SetError(txtProductionCounter, Strings.InvalidCounter);
        }

        private void NotifyOfInvalidDiscardedMachineItems()
        {
            errorProvider.SetError(txtDiscarded, Strings.InvalidCounter);
        }

        private void CancelEvent(CancelEventArgs args)
        {
            args.Cancel = true;
        }

        private void OnTextBoxEnter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            GUIHelper.MaximizeButton(sender as Button);
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            GUIHelper.MinimizeButton(sender as Button);
        }

        private void SetTexts()
        {
            this.dtUpdateDate.Value = DateTime.Now;
            this.txtProductionCounter.Text = validator.LastProductionCounter.ToString();
            this.txtDiscarded.Text = validator.LastDiscardedItems.ToString();
            
            this.lblUpdateDate.Text = Strings.UpdateDate;
            this.lblUpdateTime.Text = Strings.UpdateTime;
            this.lblProductionCounter.Text = Strings.ProductionCounter;
            
            lblHeader.Text = Strings.ProductionShiftStatistics;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            ucUpdateTime.Value = DateTime.Now.TimeOfDay;
        }         
    }
}
