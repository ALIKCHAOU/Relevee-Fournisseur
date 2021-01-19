namespace Retenu_Fournisseur
{
    partial class MainRibbonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainRibbonForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barReleveFournisseur = new DevExpress.XtraBars.BarButtonItem();
            this.barAprops = new DevExpress.XtraBars.BarButtonItem();
            this.barUtilisateurs = new DevExpress.XtraBars.BarButtonItem();
            this.barFrounisseur = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barAccuiel = new DevExpress.XtraBars.BarButtonItem();
            this.barAcceuil = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barReleveFournisseur,
            this.barAprops,
            this.barUtilisateurs,
            this.barFrounisseur,
            this.barAcceuil});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage3,
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.Size = new System.Drawing.Size(660, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barReleveFournisseur
            // 
            this.barReleveFournisseur.Caption = "Relever Fournisseur";
            this.barReleveFournisseur.Id = 1;
            this.barReleveFournisseur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barReleveFournisseur.ImageOptions.Image")));
            this.barReleveFournisseur.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barReleveFournisseur.ImageOptions.LargeImage")));
            this.barReleveFournisseur.Name = "barReleveFournisseur";
            this.barReleveFournisseur.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barReleveFournisseur_ItemClick);
            // 
            // barAprops
            // 
            this.barAprops.Caption = "A propos";
            this.barAprops.Id = 2;
            this.barAprops.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barAprops.ImageOptions.Image")));
            this.barAprops.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barAprops.ImageOptions.LargeImage")));
            this.barAprops.Name = "barAprops";
            // 
            // barUtilisateurs
            // 
            this.barUtilisateurs.Caption = "Utilisateurs";
            this.barUtilisateurs.Id = 3;
            this.barUtilisateurs.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barUtilisateurs.ImageOptions.Image")));
            this.barUtilisateurs.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barUtilisateurs.ImageOptions.LargeImage")));
            this.barUtilisateurs.Name = "barUtilisateurs";
            // 
            // barFrounisseur
            // 
            this.barFrounisseur.Caption = "Fournisseur";
            this.barFrounisseur.Id = 4;
            this.barFrounisseur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barFrounisseur.ImageOptions.Image")));
            this.barFrounisseur.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barFrounisseur.ImageOptions.LargeImage")));
            this.barFrounisseur.Name = "barFrounisseur";
            this.barFrounisseur.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barFrounisseur_ItemClick);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Parametrage";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barAprops);
            this.ribbonPageGroup2.ItemLinks.Add(this.barUtilisateurs);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Etat  Releve Fournisseur";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barReleveFournisseur);
            this.ribbonPageGroup1.ItemLinks.Add(this.barFrounisseur);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(660, 31);
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbon;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // tabbedView1
            // 
            this.tabbedView1.RootContainer.Element = null;
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Accueil";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barAcceuil);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // barAccuiel
            // 
            this.barAccuiel.Caption = "barButtonItem1";
            this.barAccuiel.Id = 5;
            this.barAccuiel.Name = "barAccuiel";
            // 
            // barAcceuil
            // 
            this.barAcceuil.Caption = "Acceuil";
            this.barAcceuil.Id = 6;
            this.barAcceuil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barAcceuil.ImageOptions.Image")));
            this.barAcceuil.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barAcceuil.ImageOptions.LargeImage")));
            this.barAcceuil.Name = "barAcceuil";
            this.barAcceuil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barAcceuil_ItemClick);
            // 
            // MainRibbonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 449);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "MainRibbonForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Releve Fournisseur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainRibbonForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barReleveFournisseur;
        private DevExpress.XtraBars.BarButtonItem barAprops;
        private DevExpress.XtraBars.BarButtonItem barUtilisateurs;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barFrounisseur;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem barAcceuil;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barAccuiel;
    }
}