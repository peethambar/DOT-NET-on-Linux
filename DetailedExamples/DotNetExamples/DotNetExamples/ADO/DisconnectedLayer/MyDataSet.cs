// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

// 
//This source code was auto-generated by MonoXSD
//
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Runtime.Serialization;
using System.Xml;


public class MyDataSet : System.Data.DataSet, System.Xml.Serialization.IXmlSerializable {
    
    public delegate void MyTableRowChangedEventHandler(object o, MyTableRowChangedEventArgs e);
    
    private MyTableDataTable __tableMyTable;
    
    public MyDataSet() {
        this.InitializeClass();
        System.ComponentModel.CollectionChangeEventHandler handler = new System.ComponentModel.CollectionChangeEventHandler(new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged));
        this.Tables.CollectionChanged += handler;
        this.Relations.CollectionChanged += handler;
    }    
    
    public virtual MyTableDataTable _MyTable {
        get {
            return this.__tableMyTable;
        }
    }
    
    public override System.Data.DataSet Clone() {
        MyDataSet set = ((MyDataSet)(base.Clone()));
        set.InitializeFields();
        return set;
    }
    
    protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
        System.IO.StringWriter sw = new System.IO.StringWriter();
        this.WriteXmlSchema(sw);
        return System.Xml.Schema.XmlSchema.Read(new System.Xml.XmlTextReader(new System.IO.StringReader(sw.ToString())), null);
    }
    
    System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() {
        return this.GetSchemaSerializable();
    }
    
    internal virtual void InitializeClass() {
        this.DataSetName = "MyDataSet";
        this.Prefix = "";
        this.Namespace = "";
        this.Locale = new System.Globalization.CultureInfo("en-GB");
        this.CaseSensitive = false;
        this.EnforceConstraints = true;
        this.__tableMyTable = new MyTableDataTable();
        this.Tables.Add(this.__tableMyTable);
    }
    
    internal virtual void InitializeFields() {
        this.__tableMyTable.InitializeFields();
    }
    
    private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
        if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
            this.InitializeFields();
        }
    }
    
    public class MyTableDataTable : System.Data.DataTable, System.Collections.IEnumerable {
        
        private System.Data.DataColumn __columnId;
        
        private System.Data.DataColumn __columnName;
        
        private System.Data.DataColumn __columnIsMale;
        
        internal MyTableDataTable() : 
                base("MyTable") {
            this.InitializeClass();
            this.InitializeFields();
        }       
        
        public virtual int Count {
            get {
                return this.Rows.Count;
            }
        }
        
        public virtual MyTableRow this[int i] {
            get {
                return ((MyTableRow)(this.Rows[i]));
            }
        }
        
        internal virtual System.Data.DataColumn IdColumn {
            get {
                return this.__columnId;
            }
        }
        
        internal virtual System.Data.DataColumn NameColumn {
            get {
                return this.__columnName;
            }
        }
        
        internal virtual System.Data.DataColumn IsMaleColumn {
            get {
                return this.__columnIsMale;
            }
        }
        
        public event MyTableRowChangedEventHandler MyTableRowChanging;
        
        public event MyTableRowChangedEventHandler MyTableRowChanged;
        
        public event MyTableRowChangedEventHandler MyTableRowDeleting;
        
        public event MyTableRowChangedEventHandler MyTableRowDeleted;
        
        private void InitializeClass() {
            this.Columns.Add(new System.Data.DataColumn("Id", typeof(int)));
            this.Columns.Add(new System.Data.DataColumn("Name", typeof(string)));
            this.Columns.Add(new System.Data.DataColumn("IsMale", typeof(bool)));
        }
        
        internal virtual void InitializeFields() {
            this.__columnId = this.Columns["Id"];
            this.__columnName = this.Columns["Name"];
            this.__columnIsMale = this.Columns["IsMale"];
        }
        
        public virtual System.Collections.IEnumerator GetEnumerator() {
            return this.Rows.GetEnumerator();
        }
        
        public override System.Data.DataTable Clone() {
            MyTableDataTable t = ((MyTableDataTable)(base.Clone()));
            t.InitializeFields();
            return t;
        }
        
        protected override System.Data.DataTable CreateInstance() {
            return new MyTableDataTable();
        }
        
        public virtual void AddMyTableRow(MyTableRow row) {
            this.Rows.Add(row);
        }
        
        public virtual MyTableRow AddMyTableRow(int Id, string Name, bool IsMale) {
            MyTableRow row = this.NewMyTableRow();
            row["Id"] = Id;
            row["Name"] = Name;
            row["IsMale"] = IsMale;
            this.Rows.Add(row);
            return row;
        }
        
        public virtual MyTableRow NewMyTableRow() {
            return ((MyTableRow)(this.NewRow()));
        }
        
        protected override System.Data.DataRow NewRowFromBuilder(System.Data.DataRowBuilder builder) {
            return new MyTableRow(builder);
        }
        
        public virtual void RemoveMyTableRow(MyTableRow row) {
            this.Rows.Remove(row);
        }
        
        protected override System.Type GetRowType() {
            return typeof(MyTableRow);
        }
        
        protected override void OnRowChanging(System.Data.DataRowChangeEventArgs e) {
            base.OnRowChanging(e);
            if ((this.MyTableRowChanging != null)) {
                this.MyTableRowChanging(this, new MyTableRowChangedEventArgs(((MyTableRow)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowChanged(System.Data.DataRowChangeEventArgs e) {
            base.OnRowChanged(e);
            if ((this.MyTableRowChanged != null)) {
                this.MyTableRowChanged(this, new MyTableRowChangedEventArgs(((MyTableRow)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleting(System.Data.DataRowChangeEventArgs e) {
            base.OnRowDeleting(e);
            if ((this.MyTableRowDeleting != null)) {
                this.MyTableRowDeleting(this, new MyTableRowChangedEventArgs(((MyTableRow)(e.Row)), e.Action));
            }
        }
        
        protected override void OnRowDeleted(System.Data.DataRowChangeEventArgs e) {
            base.OnRowDeleted(e);
            if ((this.MyTableRowDeleted != null)) {
                this.MyTableRowDeleted(this, new MyTableRowChangedEventArgs(((MyTableRow)(e.Row)), e.Action));
            }
        }
    }
    
    public class MyTableRow : System.Data.DataRow {
        
        private MyTableDataTable tableMyTable;
        
        internal MyTableRow(System.Data.DataRowBuilder builder) : 
                base(builder) {
            this.tableMyTable = ((MyTableDataTable)(this.Table));
        }
        
        public virtual int Id {
            get {
                object ret = this[this.tableMyTable.IdColumn];
                if ((ret == System.DBNull.Value)) {
                    throw new System.Data.StrongTypingException("Cannot get strong typed value since it is DB null.", null);
                }
                else {
                    return ((int)(ret));
                }
            }
            set {
                this[this.tableMyTable.IdColumn] = value;
            }
        }
        
        public virtual string Name {
            get {
                object ret = this[this.tableMyTable.NameColumn];
                if ((ret == System.DBNull.Value)) {
                    throw new System.Data.StrongTypingException("Cannot get strong typed value since it is DB null.", null);
                }
                else {
                    return ((string)(ret));
                }
            }
            set {
                this[this.tableMyTable.NameColumn] = value;
            }
        }
        
        public virtual bool IsMale {
            get {
                object ret = this[this.tableMyTable.IsMaleColumn];
                if ((ret == System.DBNull.Value)) {
                    throw new System.Data.StrongTypingException("Cannot get strong typed value since it is DB null.", null);
                }
                else {
                    return ((bool)(ret));
                }
            }
            set {
                this[this.tableMyTable.IsMaleColumn] = value;
            }
        }
        
        public virtual bool IsIdNull() {
            return this.IsNull(this.tableMyTable.IdColumn);
        }
        
        public virtual void SetIdNull() {
            this[this.tableMyTable.IdColumn] = System.DBNull.Value;
        }
        
        public virtual bool IsNameNull() {
            return this.IsNull(this.tableMyTable.NameColumn);
        }
        
        public virtual void SetNameNull() {
            this[this.tableMyTable.NameColumn] = System.DBNull.Value;
        }
        
        public virtual bool IsIsMaleNull() {
            return this.IsNull(this.tableMyTable.IsMaleColumn);
        }
        
        public virtual void SetIsMaleNull() {
            this[this.tableMyTable.IsMaleColumn] = System.DBNull.Value;
        }
    }
    
    public class MyTableRowChangedEventArgs : System.EventArgs {
        
        private MyTableRow eventRow;
        
        private System.Data.DataRowAction eventAction;
        
        public MyTableRowChangedEventArgs(MyTableRow r, System.Data.DataRowAction a) {
            this.eventRow = r;
            this.eventAction = a;
        }
        
        public MyTableRow Row {
            get {
                return this.eventRow;
            }
        }
        
        public System.Data.DataRowAction Action {
            get {
                return this.eventAction;
            }
        }
    }
}