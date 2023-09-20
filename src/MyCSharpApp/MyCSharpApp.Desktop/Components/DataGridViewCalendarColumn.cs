using Newtonsoft.Json.Linq;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace MyCSharpApp.Desktop.Components
{
    /// <summary>
    /// Provides a calendar column for the DataGridView control.
    /// Original code from Microsoft https://tinyurl.com/y8nr9okh
    /// </summary>
    public class DataGridViewCalendarColumn : DataGridViewColumn
    {
        public DataGridViewCalendarColumn() : base(new DataGridViewCalendarCell())
        {
        }

        public DataGridViewCalendarColumn(DateTime DTValue, DateTime MinDate, DateTime MaxDate) : base(new DataGridViewCalendarCell(DTValue, MinDate, MaxDate))
        {
        }

        public override DataGridViewCell CellTemplate
        {
            get => base.CellTemplate;
            set
            {

                if (value != null && !(value.GetType().IsAssignableFrom(typeof(DataGridViewCalendarCell))))
                {
                    throw new InvalidCastException("Must be a DataGridViewCalendarCell");
                }

                base.CellTemplate = value;
            }
        }
    }
    public class DataGridViewCalendarCell : DataGridViewTextBoxCell
    {
        /// <summary>
        /// Set default Date
        /// </summary>
        public DateTime EmptyDate { get; set; }
        private DateTime maxDate { get; set; }
        private DateTime minDate { get; set; }

        public DataGridViewCalendarCell()
        {
            Style.Format = "dd/MM/yyyy";
            EmptyDate = DateTime.Now;
            this.minDate = DateTime.Today.AddYears(-150);
            this.maxDate = DateTime.Today;
        }

        public DataGridViewCalendarCell(DateTime DTValue, DateTime MinDate, DateTime MaxDate)
        {
            Style.Format = "dd/MM/yyyy";
            EmptyDate = DateTime.Now;
            this.Value = DTValue;
            this.minDate = MinDate;
            this.maxDate = MaxDate;
        }

        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
            var theControl = (DataGridViewCalendarEditingControl) DataGridView.EditingControl;

            if (Convert.IsDBNull(this.Value) || (this.Value == null))
            {
                theControl.Value = DateTime.Now;
            }
            else
            {
                theControl.Value = Convert.ToDateTime(this.Value);
                theControl.MaxDate = this.maxDate;
                theControl.MinDate = this.minDate;
            }
        }

        public override Type EditType => typeof(DataGridViewCalendarEditingControl);
        public override Type ValueType => typeof(DateTime);
        public override object DefaultNewRowValue => DateTime.Now;
    }

    /// <summary>
    /// Provides Calendar popup within the DataGridView.
    /// </summary>
    /// <remarks></remarks>
    internal class DataGridViewCalendarEditingControl : DateTimePicker, IDataGridViewEditingControl
    {
        private DataGridView _dataGridViewControl;
        private bool _valueChanged = false;
        private int _rowIndexNumber;

        public DataGridViewCalendarEditingControl()
        {
            this.Format = DateTimePickerFormat.Short;
        }

        public object EditingControlFormattedValue
        {
            get => DateTime.ParseExact(Convert.ToString(Value.ToShortDateString()), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            set
            {
                if (value is string)
                {
                    Value = DateTime.ParseExact(Convert.ToString(value), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
            }
        }
        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
        {
            //return DateTime.ParseExact(Convert.ToString(Value.ToString()), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            //return this.Value.ToString(CultureInfo.InvariantCulture);
            return this.Value.ToShortDateString();
        }
        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            Font = dataGridViewCellStyle.Font;
            CalendarForeColor = dataGridViewCellStyle.ForeColor;
            CalendarMonthBackground = dataGridViewCellStyle.BackColor;
        }

        public int EditingControlRowIndex
        {
            get => _rowIndexNumber;
            set => _rowIndexNumber = value;
        }
        public bool EditingControlWantsInputKey(Keys key, bool dataGridViewWantsInputKey)
        {
            switch (key)
            {
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Home:
                case Keys.End:
                case Keys.PageDown:
                case Keys.PageUp:
                    return true;

                default:
                    return false;
            }
        }

        public void PrepareEditingControlForEdit(bool selectAll)
        {
        }
        public bool RepositionEditingControlOnValueChange => false;

        public DataGridView EditingControlDataGridView
        {
            get => _dataGridViewControl;
            set => _dataGridViewControl = value;
        }
        public bool EditingControlValueChanged
        {
            get => _valueChanged;
            set => _valueChanged = value;
        }
        Cursor IDataGridViewEditingControl.EditingPanelCursor => EditingControlCursor;
        public Cursor EditingControlCursor => base.Cursor;

        protected override void OnValueChanged(EventArgs eventArgs)
        {
            _valueChanged = true;
            EditingControlDataGridView.NotifyCurrentCellDirty(true);
            base.OnValueChanged(eventArgs);
        }
    }
}