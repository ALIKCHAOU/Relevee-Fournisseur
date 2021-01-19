namespace Retenu_Fournisseur.Forms
{
    partial class FrmFournisseur
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.frounisseurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colCT_Adresse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCT_CodePostal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCT_Complement = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCT_Contact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCT_Identifiant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCT_Intitule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCT_Num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCT_Pays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCT_Telecopie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCT_Telephone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCT_Ville = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
            this.layoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frounisseurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.groupControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(917, 396);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl2);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(893, 372);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.layoutControl3);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(2, 20);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(889, 350);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // layoutControl3
            // 
            this.layoutControl3.Controls.Add(this.gridControl1);
            this.layoutControl3.Location = new System.Drawing.Point(12, 12);
            this.layoutControl3.Name = "layoutControl3";
            this.layoutControl3.Root = this.Root;
            this.layoutControl3.Size = new System.Drawing.Size(865, 326);
            this.layoutControl3.TabIndex = 4;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.frounisseurBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(841, 302);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // frounisseurBindingSource
            // 
            this.frounisseurBindingSource.DataSource = typeof(Retenu_Fournisseur.Model.Frounisseur);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCT_Num,
            this.colCT_Intitule,
            this.colCT_Identifiant,
            this.colCT_Adresse,
            this.colCT_CodePostal,
            this.colCT_Complement,
            this.colCT_Contact,
            this.colCT_Pays,
            this.colCT_Telecopie,
            this.colCT_Telephone,
            this.colCT_Ville});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(865, 326);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(845, 306);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(889, 350);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.layoutControl3;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(869, 330);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(917, 396);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(897, 376);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // colCT_Adresse
            // 
            this.colCT_Adresse.Caption = "Adresse";
            this.colCT_Adresse.FieldName = "CT_Adresse";
            this.colCT_Adresse.Name = "colCT_Adresse";
            this.colCT_Adresse.Visible = true;
            this.colCT_Adresse.VisibleIndex = 1;
            // 
            // colCT_CodePostal
            // 
            this.colCT_CodePostal.Caption = "CodePostal";
            this.colCT_CodePostal.FieldName = "CT_CodePostal";
            this.colCT_CodePostal.Name = "colCT_CodePostal";
            this.colCT_CodePostal.Visible = true;
            this.colCT_CodePostal.VisibleIndex = 4;
            // 
            // colCT_Complement
            // 
            this.colCT_Complement.Caption = "Complement";
            this.colCT_Complement.FieldName = "CT_Complement";
            this.colCT_Complement.Name = "colCT_Complement";
            this.colCT_Complement.Visible = true;
            this.colCT_Complement.VisibleIndex = 10;
            // 
            // colCT_Contact
            // 
            this.colCT_Contact.Caption = "Contact";
            this.colCT_Contact.FieldName = "CT_Contact";
            this.colCT_Contact.Name = "colCT_Contact";
            this.colCT_Contact.Visible = true;
            this.colCT_Contact.VisibleIndex = 6;
            // 
            // colCT_Identifiant
            // 
            this.colCT_Identifiant.Caption = "Identifiant";
            this.colCT_Identifiant.FieldName = "CT_Identifiant";
            this.colCT_Identifiant.Name = "colCT_Identifiant";
            this.colCT_Identifiant.Visible = true;
            this.colCT_Identifiant.VisibleIndex = 2;
            // 
            // colCT_Intitule
            // 
            this.colCT_Intitule.Caption = "Intitule";
            this.colCT_Intitule.FieldName = "CT_Intitule";
            this.colCT_Intitule.Name = "colCT_Intitule";
            this.colCT_Intitule.Visible = true;
            this.colCT_Intitule.VisibleIndex = 3;
            // 
            // colCT_Num
            // 
            this.colCT_Num.Caption = "Num";
            this.colCT_Num.FieldName = "CT_Num";
            this.colCT_Num.Name = "colCT_Num";
            this.colCT_Num.Visible = true;
            this.colCT_Num.VisibleIndex = 0;
            // 
            // colCT_Pays
            // 
            this.colCT_Pays.Caption = "Pays";
            this.colCT_Pays.FieldName = "CT_Pays";
            this.colCT_Pays.Name = "colCT_Pays";
            this.colCT_Pays.Visible = true;
            this.colCT_Pays.VisibleIndex = 9;
            // 
            // colCT_Telecopie
            // 
            this.colCT_Telecopie.Caption = "Telecopie";
            this.colCT_Telecopie.FieldName = "CT_Telecopie";
            this.colCT_Telecopie.Name = "colCT_Telecopie";
            this.colCT_Telecopie.Visible = true;
            this.colCT_Telecopie.VisibleIndex = 7;
            // 
            // colCT_Telephone
            // 
            this.colCT_Telephone.Caption = "Telephone";
            this.colCT_Telephone.FieldName = "CT_Telephone";
            this.colCT_Telephone.Name = "colCT_Telephone";
            this.colCT_Telephone.Visible = true;
            this.colCT_Telephone.VisibleIndex = 5;
            // 
            // colCT_Ville
            // 
            this.colCT_Ville.Caption = "Ville";
            this.colCT_Ville.FieldName = "CT_Ville";
            this.colCT_Ville.Name = "colCT_Ville";
            this.colCT_Ville.Visible = true;
            this.colCT_Ville.VisibleIndex = 8;
            // 
            // FrmFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 396);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmFournisseur";
            this.Text = "Fournisseur";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmFournisseur_FormClosed);
            this.Load += new System.EventHandler(this.FrmFournisseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
            this.layoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frounisseurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource frounisseurBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn colCT_Num;
        private DevExpress.XtraGrid.Columns.GridColumn colCT_Intitule;
        private DevExpress.XtraGrid.Columns.GridColumn colCT_Identifiant;
        private DevExpress.XtraGrid.Columns.GridColumn colCT_Adresse;
        private DevExpress.XtraGrid.Columns.GridColumn colCT_CodePostal;
        private DevExpress.XtraGrid.Columns.GridColumn colCT_Complement;
        private DevExpress.XtraGrid.Columns.GridColumn colCT_Contact;
        private DevExpress.XtraGrid.Columns.GridColumn colCT_Pays;
        private DevExpress.XtraGrid.Columns.GridColumn colCT_Telecopie;
        private DevExpress.XtraGrid.Columns.GridColumn colCT_Telephone;
        private DevExpress.XtraGrid.Columns.GridColumn colCT_Ville;
    }
}