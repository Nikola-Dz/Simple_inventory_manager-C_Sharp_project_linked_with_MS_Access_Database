namespace Magacin_PBP
{
    partial class Form_Magacin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label Label_Naziv;
            System.Windows.Forms.Label Label_Kategorija;
            System.Windows.Forms.Label Label_Tezina;
            System.Windows.Forms.Label Label_Vrednost;
            System.Windows.Forms.Label Label_Datum_dospeca;
            System.Windows.Forms.Label Label_Broj_komada;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Magacin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.table_AsortimanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magacin_DatabaseDataSet = new Magacin_PBP.Magacin_DatabaseDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigator_Dodaj = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator_Izbrisi = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator_Sacuvaj = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator_Osvezi = new System.Windows.Forms.ToolStripButton();
            this.button_Prethodni = new System.Windows.Forms.Button();
            this.button_Dodaj = new System.Windows.Forms.Button();
            this.button_Sledeci = new System.Windows.Forms.Button();
            this.button_Izadji = new System.Windows.Forms.Button();
            this.button_Izbrisi = new System.Windows.Forms.Button();
            this.button_Sacuvaj = new System.Windows.Forms.Button();
            this.TextBox_Naziv = new System.Windows.Forms.TextBox();
            this.TextBox_Tezina = new System.Windows.Forms.TextBox();
            this.TextBox_Vrednost = new System.Windows.Forms.TextBox();
            this.DateTimePicker_Datum_dospeca = new System.Windows.Forms.DateTimePicker();
            this.DataGridView_Table_Asortiman = new System.Windows.Forms.DataGridView();
            this.groupBox_Unos_podataka = new System.Windows.Forms.GroupBox();
            this.TextBox_Broj_komada = new System.Windows.Forms.TextBox();
            this.comboBox_Kategorija = new System.Windows.Forms.ComboBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.table_AsortimanTableAdapter = new Magacin_PBP.Magacin_DatabaseDataSetTableAdapters.Table_AsortimanTableAdapter();
            this.tableAdapterManager = new Magacin_PBP.Magacin_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.button_Export3 = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Label_Naziv = new System.Windows.Forms.Label();
            Label_Kategorija = new System.Windows.Forms.Label();
            Label_Tezina = new System.Windows.Forms.Label();
            Label_Vrednost = new System.Windows.Forms.Label();
            Label_Datum_dospeca = new System.Windows.Forms.Label();
            Label_Broj_komada = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_AsortimanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magacin_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Table_Asortiman)).BeginInit();
            this.groupBox_Unos_podataka.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_Naziv
            // 
            Label_Naziv.AutoSize = true;
            Label_Naziv.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label_Naziv.Location = new System.Drawing.Point(18, 37);
            Label_Naziv.Name = "Label_Naziv";
            Label_Naziv.Size = new System.Drawing.Size(48, 18);
            Label_Naziv.TabIndex = 10;
            Label_Naziv.Text = "Naziv:";
            // 
            // Label_Kategorija
            // 
            Label_Kategorija.AutoSize = true;
            Label_Kategorija.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label_Kategorija.Location = new System.Drawing.Point(18, 69);
            Label_Kategorija.Name = "Label_Kategorija";
            Label_Kategorija.Size = new System.Drawing.Size(78, 18);
            Label_Kategorija.TabIndex = 12;
            Label_Kategorija.Text = "Kategorija:";
            // 
            // Label_Tezina
            // 
            Label_Tezina.AutoSize = true;
            Label_Tezina.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label_Tezina.Location = new System.Drawing.Point(18, 133);
            Label_Tezina.Name = "Label_Tezina";
            Label_Tezina.Size = new System.Drawing.Size(88, 18);
            Label_Tezina.TabIndex = 14;
            Label_Tezina.Text = "Težina (kg):";
            // 
            // Label_Vrednost
            // 
            Label_Vrednost.AutoSize = true;
            Label_Vrednost.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label_Vrednost.Location = new System.Drawing.Point(18, 165);
            Label_Vrednost.Name = "Label_Vrednost";
            Label_Vrednost.Size = new System.Drawing.Size(106, 18);
            Label_Vrednost.TabIndex = 16;
            Label_Vrednost.Text = "Vrednost (din):";
            Label_Vrednost.Click += new System.EventHandler(this.Label_Vrednost_Click);
            // 
            // Label_Datum_dospeca
            // 
            Label_Datum_dospeca.AutoSize = true;
            Label_Datum_dospeca.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label_Datum_dospeca.Location = new System.Drawing.Point(18, 197);
            Label_Datum_dospeca.Name = "Label_Datum_dospeca";
            Label_Datum_dospeca.Size = new System.Drawing.Size(116, 18);
            Label_Datum_dospeca.TabIndex = 18;
            Label_Datum_dospeca.Text = "Datum dospeća:";
            // 
            // Label_Broj_komada
            // 
            Label_Broj_komada.AutoSize = true;
            Label_Broj_komada.Location = new System.Drawing.Point(18, 101);
            Label_Broj_komada.Name = "Label_Broj_komada";
            Label_Broj_komada.Size = new System.Drawing.Size(96, 18);
            Label_Broj_komada.TabIndex = 22;
            Label_Broj_komada.Text = "Broj komada:";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.table_AsortimanBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigator_Dodaj,
            this.bindingNavigator_Izbrisi,
            this.bindingNavigator_Sacuvaj,
            this.bindingNavigator_Osvezi});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator1.Size = new System.Drawing.Size(842, 31);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.RefreshItems += new System.EventHandler(this.bindingNavigator1_RefreshItems);
            // 
            // table_AsortimanBindingSource
            // 
            this.table_AsortimanBindingSource.DataMember = "Table_Asortiman";
            this.table_AsortimanBindingSource.DataSource = this.magacin_DatabaseDataSet;
            // 
            // magacin_DatabaseDataSet
            // 
            this.magacin_DatabaseDataSet.DataSetName = "Magacin_DatabaseDataSet";
            this.magacin_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Ukupan broj proizvoda";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.ToolTipText = "Početak";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.ToolTipText = "Prethodni";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(44, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Trenutna pozicija";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.ToolTipText = "Sledeći";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.ToolTipText = "Kraj";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigator_Dodaj
            // 
            this.bindingNavigator_Dodaj.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigator_Dodaj.Image")));
            this.bindingNavigator_Dodaj.Name = "bindingNavigator_Dodaj";
            this.bindingNavigator_Dodaj.RightToLeftAutoMirrorImage = true;
            this.bindingNavigator_Dodaj.Size = new System.Drawing.Size(70, 28);
            this.bindingNavigator_Dodaj.Text = "Dodaj";
            this.bindingNavigator_Dodaj.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigator_Izbrisi
            // 
            this.bindingNavigator_Izbrisi.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigator_Izbrisi.Image")));
            this.bindingNavigator_Izbrisi.Name = "bindingNavigator_Izbrisi";
            this.bindingNavigator_Izbrisi.RightToLeftAutoMirrorImage = true;
            this.bindingNavigator_Izbrisi.Size = new System.Drawing.Size(69, 28);
            this.bindingNavigator_Izbrisi.Text = "Izbriši";
            this.bindingNavigator_Izbrisi.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigator_Sacuvaj
            // 
            this.bindingNavigator_Sacuvaj.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigator_Sacuvaj.Image")));
            this.bindingNavigator_Sacuvaj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigator_Sacuvaj.Name = "bindingNavigator_Sacuvaj";
            this.bindingNavigator_Sacuvaj.Size = new System.Drawing.Size(83, 28);
            this.bindingNavigator_Sacuvaj.Text = "Sačuvaj";
            this.bindingNavigator_Sacuvaj.Click += new System.EventHandler(this.bindingNavigatorUpdateItem_Click);
            // 
            // bindingNavigator_Osvezi
            // 
            this.bindingNavigator_Osvezi.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigator_Osvezi.Image")));
            this.bindingNavigator_Osvezi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigator_Osvezi.Name = "bindingNavigator_Osvezi";
            this.bindingNavigator_Osvezi.Size = new System.Drawing.Size(75, 28);
            this.bindingNavigator_Osvezi.Text = "Osveži";
            this.bindingNavigator_Osvezi.Click += new System.EventHandler(this.bindingNavigatorRefreshItem_Click);
            // 
            // button_Prethodni
            // 
            this.button_Prethodni.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Prethodni.Image = ((System.Drawing.Image)(resources.GetObject("button_Prethodni.Image")));
            this.button_Prethodni.Location = new System.Drawing.Point(513, 77);
            this.button_Prethodni.Name = "button_Prethodni";
            this.button_Prethodni.Size = new System.Drawing.Size(121, 48);
            this.button_Prethodni.TabIndex = 2;
            this.button_Prethodni.Text = "Prethodni";
            this.button_Prethodni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Prethodni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Prethodni.UseVisualStyleBackColor = true;
            this.button_Prethodni.Click += new System.EventHandler(this.button_Prethodni_Click);
            // 
            // button_Dodaj
            // 
            this.button_Dodaj.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Dodaj.Image = ((System.Drawing.Image)(resources.GetObject("button_Dodaj.Image")));
            this.button_Dodaj.Location = new System.Drawing.Point(386, 77);
            this.button_Dodaj.Name = "button_Dodaj";
            this.button_Dodaj.Size = new System.Drawing.Size(121, 48);
            this.button_Dodaj.TabIndex = 3;
            this.button_Dodaj.Text = "Dodaj";
            this.button_Dodaj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Dodaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Dodaj.UseVisualStyleBackColor = true;
            this.button_Dodaj.Click += new System.EventHandler(this.button_Dodaj_Click);
            // 
            // button_Sledeci
            // 
            this.button_Sledeci.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sledeci.Image = ((System.Drawing.Image)(resources.GetObject("button_Sledeci.Image")));
            this.button_Sledeci.Location = new System.Drawing.Point(640, 77);
            this.button_Sledeci.Name = "button_Sledeci";
            this.button_Sledeci.Size = new System.Drawing.Size(121, 48);
            this.button_Sledeci.TabIndex = 4;
            this.button_Sledeci.Text = "Sledeći";
            this.button_Sledeci.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Sledeci.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_Sledeci.UseVisualStyleBackColor = true;
            this.button_Sledeci.Click += new System.EventHandler(this.button_Sledeci_Click);
            // 
            // button_Izadji
            // 
            this.button_Izadji.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Izadji.Image = ((System.Drawing.Image)(resources.GetObject("button_Izadji.Image")));
            this.button_Izadji.Location = new System.Drawing.Point(640, 131);
            this.button_Izadji.Name = "button_Izadji";
            this.button_Izadji.Size = new System.Drawing.Size(121, 48);
            this.button_Izadji.TabIndex = 7;
            this.button_Izadji.Text = "Izađi";
            this.button_Izadji.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Izadji.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Izadji.UseVisualStyleBackColor = true;
            this.button_Izadji.Click += new System.EventHandler(this.button_Izadji_Click);
            // 
            // button_Izbrisi
            // 
            this.button_Izbrisi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Izbrisi.Image = ((System.Drawing.Image)(resources.GetObject("button_Izbrisi.Image")));
            this.button_Izbrisi.Location = new System.Drawing.Point(513, 131);
            this.button_Izbrisi.Name = "button_Izbrisi";
            this.button_Izbrisi.Size = new System.Drawing.Size(121, 48);
            this.button_Izbrisi.TabIndex = 6;
            this.button_Izbrisi.Text = "Izbriši";
            this.button_Izbrisi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Izbrisi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Izbrisi.UseVisualStyleBackColor = true;
            this.button_Izbrisi.Click += new System.EventHandler(this.button_Izbrisi_Click);
            // 
            // button_Sacuvaj
            // 
            this.button_Sacuvaj.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sacuvaj.Image = ((System.Drawing.Image)(resources.GetObject("button_Sacuvaj.Image")));
            this.button_Sacuvaj.Location = new System.Drawing.Point(386, 131);
            this.button_Sacuvaj.Name = "button_Sacuvaj";
            this.button_Sacuvaj.Size = new System.Drawing.Size(121, 48);
            this.button_Sacuvaj.TabIndex = 5;
            this.button_Sacuvaj.Text = "Sačuvaj";
            this.button_Sacuvaj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Sacuvaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Sacuvaj.UseVisualStyleBackColor = true;
            this.button_Sacuvaj.Click += new System.EventHandler(this.button_Sacuvaj_Click);
            // 
            // TextBox_Naziv
            // 
            this.TextBox_Naziv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_AsortimanBindingSource, "Naziv", true));
            this.TextBox_Naziv.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Naziv.Location = new System.Drawing.Point(133, 34);
            this.TextBox_Naziv.Name = "TextBox_Naziv";
            this.TextBox_Naziv.Size = new System.Drawing.Size(176, 26);
            this.TextBox_Naziv.TabIndex = 11;
            this.TextBox_Naziv.TextChanged += new System.EventHandler(this.TextBox_Naziv_TextChanged);
            // 
            // TextBox_Tezina
            // 
            this.TextBox_Tezina.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_AsortimanBindingSource, "Težina", true));
            this.TextBox_Tezina.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Tezina.Location = new System.Drawing.Point(133, 130);
            this.TextBox_Tezina.Name = "TextBox_Tezina";
            this.TextBox_Tezina.Size = new System.Drawing.Size(176, 26);
            this.TextBox_Tezina.TabIndex = 15;
            // 
            // TextBox_Vrednost
            // 
            this.TextBox_Vrednost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_AsortimanBindingSource, "Vrednost", true));
            this.TextBox_Vrednost.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Vrednost.Location = new System.Drawing.Point(133, 162);
            this.TextBox_Vrednost.Name = "TextBox_Vrednost";
            this.TextBox_Vrednost.Size = new System.Drawing.Size(176, 26);
            this.TextBox_Vrednost.TabIndex = 17;
            this.TextBox_Vrednost.TextChanged += new System.EventHandler(this.TextBox_Vrednost_TextChanged);
            // 
            // DateTimePicker_Datum_dospeca
            // 
            this.DateTimePicker_Datum_dospeca.CustomFormat = "";
            this.DateTimePicker_Datum_dospeca.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.table_AsortimanBindingSource, "Datum dospeća", true));
            this.DateTimePicker_Datum_dospeca.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker_Datum_dospeca.Location = new System.Drawing.Point(133, 194);
            this.DateTimePicker_Datum_dospeca.Name = "DateTimePicker_Datum_dospeca";
            this.DateTimePicker_Datum_dospeca.ShowCheckBox = true;
            this.DateTimePicker_Datum_dospeca.Size = new System.Drawing.Size(176, 26);
            this.DateTimePicker_Datum_dospeca.TabIndex = 19;
            // 
            // DataGridView_Table_Asortiman
            // 
            this.DataGridView_Table_Asortiman.AllowUserToAddRows = false;
            this.DataGridView_Table_Asortiman.AllowUserToDeleteRows = false;
            this.DataGridView_Table_Asortiman.AllowUserToOrderColumns = true;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Gainsboro;
            this.DataGridView_Table_Asortiman.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DataGridView_Table_Asortiman.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_Table_Asortiman.AutoGenerateColumns = false;
            this.DataGridView_Table_Asortiman.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_Table_Asortiman.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Table_Asortiman.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DataGridView_Table_Asortiman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Table_Asortiman.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.DataGridView_Table_Asortiman.DataSource = this.table_AsortimanBindingSource;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_Table_Asortiman.DefaultCellStyle = dataGridViewCellStyle17;
            this.DataGridView_Table_Asortiman.Location = new System.Drawing.Point(13, 294);
            this.DataGridView_Table_Asortiman.Name = "DataGridView_Table_Asortiman";
            this.DataGridView_Table_Asortiman.ReadOnly = true;
            this.DataGridView_Table_Asortiman.RowHeadersWidth = 51;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Silver;
            this.DataGridView_Table_Asortiman.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.DataGridView_Table_Asortiman.RowTemplate.Height = 24;
            this.DataGridView_Table_Asortiman.Size = new System.Drawing.Size(818, 209);
            this.DataGridView_Table_Asortiman.TabIndex = 20;
            // 
            // groupBox_Unos_podataka
            // 
            this.groupBox_Unos_podataka.AutoSize = true;
            this.groupBox_Unos_podataka.Controls.Add(Label_Broj_komada);
            this.groupBox_Unos_podataka.Controls.Add(this.TextBox_Broj_komada);
            this.groupBox_Unos_podataka.Controls.Add(this.comboBox_Kategorija);
            this.groupBox_Unos_podataka.Controls.Add(this.TextBox_Naziv);
            this.groupBox_Unos_podataka.Controls.Add(this.DateTimePicker_Datum_dospeca);
            this.groupBox_Unos_podataka.Controls.Add(Label_Naziv);
            this.groupBox_Unos_podataka.Controls.Add(Label_Datum_dospeca);
            this.groupBox_Unos_podataka.Controls.Add(this.TextBox_Vrednost);
            this.groupBox_Unos_podataka.Controls.Add(Label_Kategorija);
            this.groupBox_Unos_podataka.Controls.Add(Label_Vrednost);
            this.groupBox_Unos_podataka.Controls.Add(this.TextBox_Tezina);
            this.groupBox_Unos_podataka.Controls.Add(Label_Tezina);
            this.groupBox_Unos_podataka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox_Unos_podataka.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Unos_podataka.Location = new System.Drawing.Point(13, 43);
            this.groupBox_Unos_podataka.Name = "groupBox_Unos_podataka";
            this.groupBox_Unos_podataka.Size = new System.Drawing.Size(315, 245);
            this.groupBox_Unos_podataka.TabIndex = 21;
            this.groupBox_Unos_podataka.TabStop = false;
            this.groupBox_Unos_podataka.Text = "Unos podataka";
            // 
            // TextBox_Broj_komada
            // 
            this.TextBox_Broj_komada.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_AsortimanBindingSource, "Broj komada", true));
            this.TextBox_Broj_komada.Location = new System.Drawing.Point(133, 98);
            this.TextBox_Broj_komada.Name = "TextBox_Broj_komada";
            this.TextBox_Broj_komada.Size = new System.Drawing.Size(176, 26);
            this.TextBox_Broj_komada.TabIndex = 23;
            // 
            // comboBox_Kategorija
            // 
            this.comboBox_Kategorija.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.table_AsortimanBindingSource, "Kategorija", true));
            this.comboBox_Kategorija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Kategorija.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Kategorija.FormattingEnabled = true;
            this.comboBox_Kategorija.Items.AddRange(new object[] {
            "-Izaberite kategoriju-",
            "Kućna hemija",
            "Kućni ljubimci",
            "Lična higijena",
            "Meso i riba",
            "Mlečni proizvodi",
            "Ostale namirnice",
            "Pića",
            "Slatkiši i grickalice",
            "Smrznuto",
            "Voće i povrće"});
            this.comboBox_Kategorija.Location = new System.Drawing.Point(133, 66);
            this.comboBox_Kategorija.Name = "comboBox_Kategorija";
            this.comboBox_Kategorija.Size = new System.Drawing.Size(176, 26);
            this.comboBox_Kategorija.TabIndex = 22;
            this.comboBox_Kategorija.SelectedIndexChanged += new System.EventHandler(this.comboBox_Kategorija_SelectedIndexChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 506);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(842, 22);
            this.statusStrip.TabIndex = 22;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(280, 18);
            this.toolStripProgressBar.Step = 20;
            this.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.toolStripProgressBar.Visible = false;
            this.toolStripProgressBar.Click += new System.EventHandler(this.toolStripProgressBar1_Click);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Font = new System.Drawing.Font("Tahoma", 9F);
            this.toolStripStatusLabel.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.toolStripStatusLabel.Size = new System.Drawing.Size(5, 0);
            this.toolStripStatusLabel.Visible = false;
            // 
            // table_AsortimanTableAdapter
            // 
            this.table_AsortimanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Table_AsortimanTableAdapter = this.table_AsortimanTableAdapter;
            this.tableAdapterManager.UpdateOrder = Magacin_PBP.Magacin_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button_Export3
            // 
            this.button_Export3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Export3.Image = ((System.Drawing.Image)(resources.GetObject("button_Export3.Image")));
            this.button_Export3.Location = new System.Drawing.Point(513, 193);
            this.button_Export3.Name = "button_Export3";
            this.button_Export3.Size = new System.Drawing.Size(121, 48);
            this.button_Export3.TabIndex = 23;
            this.button_Export3.Text = "Export";
            this.button_Export3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Export3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Export3.UseVisualStyleBackColor = true;
            this.button_Export3.Click += new System.EventHandler(this.button_Export_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Proizvod_ID";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn1.HeaderText = "Proizvod ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Naziv";
            this.dataGridViewTextBoxColumn2.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Kategorija";
            this.dataGridViewTextBoxColumn3.HeaderText = "Kategorija";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Broj komada";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn7.HeaderText = "Broj komada";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Težina";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "#,##\" kg\"";
            dataGridViewCellStyle14.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn4.HeaderText = "Težina";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Vrednost";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "#,##0.00 din.";
            dataGridViewCellStyle15.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn5.HeaderText = "Vrednost";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Datum dospeća";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTextBoxColumn6.HeaderText = "Datum dospeća";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Form_Magacin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 528);
            this.Controls.Add(this.button_Export3);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox_Unos_podataka);
            this.Controls.Add(this.DataGridView_Table_Asortiman);
            this.Controls.Add(this.button_Izadji);
            this.Controls.Add(this.button_Izbrisi);
            this.Controls.Add(this.button_Sacuvaj);
            this.Controls.Add(this.button_Sledeci);
            this.Controls.Add(this.button_Dodaj);
            this.Controls.Add(this.button_Prethodni);
            this.Controls.Add(this.bindingNavigator1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(860, 575);
            this.Name = "Form_Magacin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magacin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Magacin_FormClosing);
            this.Load += new System.EventHandler(this.Form_Magacin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_AsortimanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magacin_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Table_Asortiman)).EndInit();
            this.groupBox_Unos_podataka.ResumeLayout(false);
            this.groupBox_Unos_podataka.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigator_Dodaj;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigator_Izbrisi;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigator_Sacuvaj;
        private System.Windows.Forms.ToolStripButton bindingNavigator_Osvezi;
        private System.Windows.Forms.Button button_Prethodni;
        private System.Windows.Forms.Button button_Dodaj;
        private System.Windows.Forms.Button button_Sledeci;
        private System.Windows.Forms.Button button_Izadji;
        private System.Windows.Forms.Button button_Izbrisi;
        private System.Windows.Forms.Button button_Sacuvaj;
        private Magacin_DatabaseDataSet magacin_DatabaseDataSet;
        private System.Windows.Forms.BindingSource table_AsortimanBindingSource;
        private Magacin_DatabaseDataSetTableAdapters.Table_AsortimanTableAdapter table_AsortimanTableAdapter;
        private Magacin_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox TextBox_Naziv;
        private System.Windows.Forms.TextBox TextBox_Tezina;
        private System.Windows.Forms.TextBox TextBox_Vrednost;
        private System.Windows.Forms.DateTimePicker DateTimePicker_Datum_dospeca;
        private System.Windows.Forms.GroupBox groupBox_Unos_podataka;
        private System.Windows.Forms.ComboBox comboBox_Kategorija;
        public System.Windows.Forms.DataGridView DataGridView_Table_Asortiman;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.TextBox TextBox_Broj_komada;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Button button_Export3;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

