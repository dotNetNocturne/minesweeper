using System.ComponentModel;
using Minesweeper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperPresentationLayer
{
    public class MinesweeperPresenter : BindingList<Row>
    {
        public MinesweeperPresenter(IBoard board)
        {
            
            for (int r = 0; r < board.Height; r++)
            {
                var row = new Row();

                for (int c = 0; c < board.Width; c++)
                {
                    row.Cells.Add(board.CellMatrix[r, c]);
                }
            }
        }

    }


   

    public class Row : ICustomTypeDescriptor
    {
        public Row()
        {
            Cells = new List<ICell>();
        }


        public List<ICell> Cells { get; set; }



        public AttributeCollection GetAttributes()
        {
            return null;
        }

        public string GetClassName()
        {
            return string.Empty;

        }

        public string GetComponentName()
        {
            return typeof (Row).Name;
        }

        public TypeConverter GetConverter()
        {
            return null;
        }

        public EventDescriptor GetDefaultEvent()
        {
            return null;
        }

        public PropertyDescriptor GetDefaultProperty()
        {
            return null;
        }

        public object GetEditor(Type editorBaseType)
        {
            return null;
        }

        public EventDescriptorCollection GetEvents(Attribute[] attributes)
        {
            return null;
        }

        public EventDescriptorCollection GetEvents()
        {
            return null;
        }

        public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
        {
            return GetProperties();
        }

        public PropertyDescriptorCollection GetProperties()
        {
            var columns = new List<Column>();

            for(int i = 0; i < this.Cells.Count; i++)
            {
                columns.Add(new Column(i));
            }


            return new PropertyDescriptorCollection(columns.ToArray());
        }

        public object GetPropertyOwner(PropertyDescriptor pd)
        {
            return this;
        }
    }


    public class Column : PropertyDescriptor
    {
        private int _columnIndex = 0;
        public Column(int columnIndex)
            : base("Column " + columnIndex, new Attribute[0])
        {
            _columnIndex = columnIndex;
        }
        public override bool CanResetValue(object component)
        {
            return false;
        }

        public override Type ComponentType
        {
            get { return typeof(Row); }
        }

        public override object GetValue(object component)
        {
            var row = component as Row;

            return row.Cells[_columnIndex];
        }

        public override bool IsReadOnly
        {
            get { return true; }
        }

        public override Type PropertyType
        {
            get { return typeof(ICell); }
        }

        public override void ResetValue(object component)
        {
            
        }

        public override void SetValue(object component, object value)
        {
            
        }

        public override bool ShouldSerializeValue(object component)
        {
            return false;
        }
    }

}
