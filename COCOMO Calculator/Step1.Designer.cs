namespace COCOMO_Calculator
{
    partial class Step1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Step1));
            this.TdevLabel = new System.Windows.Forms.Label();
            this.EffortLabel = new System.Windows.Forms.Label();
            this.KolcLabel = new System.Windows.Forms.Label();
            this.EffortResult = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TDEVResult = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.NextStep = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.EffortCalculate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.TDEV_Calculate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.KOLC_Value = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ProductAttributeslabel = new System.Windows.Forms.Label();
            this.ProjectType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonPalette2 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectType)).BeginInit();
            this.SuspendLayout();
            // 
            // TdevLabel
            // 
            this.TdevLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TdevLabel.AutoSize = true;
            this.TdevLabel.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TdevLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.TdevLabel.Location = new System.Drawing.Point(241, 457);
            this.TdevLabel.Name = "TdevLabel";
            this.TdevLabel.Size = new System.Drawing.Size(111, 58);
            this.TdevLabel.TabIndex = 3;
            this.TdevLabel.Text = "TDEV";
            // 
            // EffortLabel
            // 
            this.EffortLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EffortLabel.AutoSize = true;
            this.EffortLabel.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EffortLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.EffortLabel.Location = new System.Drawing.Point(236, 322);
            this.EffortLabel.Name = "EffortLabel";
            this.EffortLabel.Size = new System.Drawing.Size(115, 58);
            this.EffortLabel.TabIndex = 4;
            this.EffortLabel.Text = "Effort";
            // 
            // KolcLabel
            // 
            this.KolcLabel.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KolcLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.KolcLabel.Location = new System.Drawing.Point(331, 107);
            this.KolcLabel.Name = "KolcLabel";
            this.KolcLabel.Size = new System.Drawing.Size(379, 60);
            this.KolcLabel.TabIndex = 5;
            this.KolcLabel.Text = "Enter The KOLC";
            // 
            // EffortResult
            // 
            this.EffortResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EffortResult.Location = new System.Drawing.Point(399, 325);
            this.EffortResult.Multiline = true;
            this.EffortResult.Name = "EffortResult";
            this.EffortResult.ReadOnly = true;
            this.EffortResult.Size = new System.Drawing.Size(241, 49);
            this.EffortResult.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.EffortResult.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.EffortResult.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.EffortResult.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.EffortResult.StateCommon.Border.Rounding = 10;
            this.EffortResult.StateCommon.Border.Width = 1;
            this.EffortResult.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.EffortResult.StateCommon.Content.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EffortResult.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 4, -1, -1);
            this.EffortResult.TabIndex = 6;
            // 
            // TDEVResult
            // 
            this.TDEVResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TDEVResult.Location = new System.Drawing.Point(399, 461);
            this.TDEVResult.Multiline = true;
            this.TDEVResult.Name = "TDEVResult";
            this.TDEVResult.ReadOnly = true;
            this.TDEVResult.Size = new System.Drawing.Size(241, 49);
            this.TDEVResult.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.TDEVResult.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.TDEVResult.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.TDEVResult.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TDEVResult.StateCommon.Border.Rounding = 10;
            this.TDEVResult.StateCommon.Border.Width = 1;
            this.TDEVResult.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.TDEVResult.StateCommon.Content.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDEVResult.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 4, -1, -1);
            this.TDEVResult.TabIndex = 7;
            // 
            // NextStep
            // 
            this.NextStep.Location = new System.Drawing.Point(941, 625);
            this.NextStep.Name = "NextStep";
            this.NextStep.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.NextStep.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.NextStep.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.NextStep.Size = new System.Drawing.Size(194, 46);
            this.NextStep.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.NextStep.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(203)))), ((int)(((byte)(93)))));
            this.NextStep.StateCommon.Back.ColorAngle = 45F;
            this.NextStep.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.NextStep.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.NextStep.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.NextStep.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.NextStep.StateCommon.Border.Rounding = 5;
            this.NextStep.StateCommon.Border.Width = 1;
            this.NextStep.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.NextStep.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.NextStep.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextStep.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.NextStep.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.NextStep.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.NextStep.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(203)))), ((int)(((byte)(93)))));
            this.NextStep.StateNormal.Back.ColorAngle = 45F;
            this.NextStep.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.NextStep.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(203)))), ((int)(((byte)(93)))));
            this.NextStep.StateNormal.Border.ColorAngle = -45F;
            this.NextStep.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.NextStep.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.NextStep.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(203)))), ((int)(((byte)(93)))));
            this.NextStep.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.NextStep.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(203)))), ((int)(((byte)(93)))));
            this.NextStep.StateTracking.Back.ColorAngle = 90F;
            this.NextStep.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.NextStep.StateTracking.Border.Width = 1;
            this.NextStep.TabIndex = 10;
            this.NextStep.Values.Text = "Next";
            this.NextStep.Click += new System.EventHandler(this.NextStep_Click);
            // 
            // EffortCalculate
            // 
            this.EffortCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EffortCalculate.Location = new System.Drawing.Point(696, 325);
            this.EffortCalculate.Name = "EffortCalculate";
            this.EffortCalculate.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.EffortCalculate.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.EffortCalculate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.EffortCalculate.Size = new System.Drawing.Size(210, 49);
            this.EffortCalculate.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.EffortCalculate.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(203)))), ((int)(((byte)(93)))));
            this.EffortCalculate.StateCommon.Back.ColorAngle = 45F;
            this.EffortCalculate.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.EffortCalculate.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.EffortCalculate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.EffortCalculate.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.EffortCalculate.StateCommon.Border.Rounding = 20;
            this.EffortCalculate.StateCommon.Border.Width = 1;
            this.EffortCalculate.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.EffortCalculate.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.EffortCalculate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EffortCalculate.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.EffortCalculate.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.EffortCalculate.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.EffortCalculate.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(203)))), ((int)(((byte)(93)))));
            this.EffortCalculate.StateNormal.Back.ColorAngle = 45F;
            this.EffortCalculate.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.EffortCalculate.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(203)))), ((int)(((byte)(93)))));
            this.EffortCalculate.StateNormal.Border.ColorAngle = -45F;
            this.EffortCalculate.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.EffortCalculate.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.EffortCalculate.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(203)))), ((int)(((byte)(93)))));
            this.EffortCalculate.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.EffortCalculate.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(203)))), ((int)(((byte)(93)))));
            this.EffortCalculate.StateTracking.Back.ColorAngle = 90F;
            this.EffortCalculate.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.EffortCalculate.StateTracking.Border.Width = 1;
            this.EffortCalculate.TabIndex = 11;
            this.EffortCalculate.Values.Text = "Calculate";
            this.EffortCalculate.Click += new System.EventHandler(this.EffortCalculate_Click);
            // 
            // TDEV_Calculate
            // 
            this.TDEV_Calculate.Location = new System.Drawing.Point(696, 461);
            this.TDEV_Calculate.Name = "TDEV_Calculate";
            this.TDEV_Calculate.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.TDEV_Calculate.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.TDEV_Calculate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.TDEV_Calculate.Size = new System.Drawing.Size(210, 49);
            this.TDEV_Calculate.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.TDEV_Calculate.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(203)))), ((int)(((byte)(93)))));
            this.TDEV_Calculate.StateCommon.Back.ColorAngle = 45F;
            this.TDEV_Calculate.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.TDEV_Calculate.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.TDEV_Calculate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TDEV_Calculate.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.TDEV_Calculate.StateCommon.Border.Rounding = 20;
            this.TDEV_Calculate.StateCommon.Border.Width = 1;
            this.TDEV_Calculate.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TDEV_Calculate.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TDEV_Calculate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDEV_Calculate.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.TDEV_Calculate.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.TDEV_Calculate.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.TDEV_Calculate.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(203)))), ((int)(((byte)(93)))));
            this.TDEV_Calculate.StateNormal.Back.ColorAngle = 45F;
            this.TDEV_Calculate.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.TDEV_Calculate.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(203)))), ((int)(((byte)(93)))));
            this.TDEV_Calculate.StateNormal.Border.ColorAngle = -45F;
            this.TDEV_Calculate.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TDEV_Calculate.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.TDEV_Calculate.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(203)))), ((int)(((byte)(93)))));
            this.TDEV_Calculate.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.TDEV_Calculate.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(203)))), ((int)(((byte)(93)))));
            this.TDEV_Calculate.StateTracking.Back.ColorAngle = 90F;
            this.TDEV_Calculate.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TDEV_Calculate.StateTracking.Border.Width = 1;
            this.TDEV_Calculate.TabIndex = 12;
            this.TDEV_Calculate.Values.Text = "Calculate";
            this.TDEV_Calculate.Click += new System.EventHandler(this.TDEV_Calculate_Click);
            // 
            // KOLC_Value
            // 
            this.KOLC_Value.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KOLC_Value.Location = new System.Drawing.Point(399, 203);
            this.KOLC_Value.Name = "KOLC_Value";
            this.KOLC_Value.Size = new System.Drawing.Size(241, 41);
            this.KOLC_Value.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.KOLC_Value.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.KOLC_Value.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.KOLC_Value.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.KOLC_Value.StateCommon.Border.Rounding = 10;
            this.KOLC_Value.StateCommon.Border.Width = 1;
            this.KOLC_Value.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.KOLC_Value.StateCommon.Content.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KOLC_Value.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 4, -1, -1);
            this.KOLC_Value.TabIndex = 13;
            // 
            // ProductAttributeslabel
            // 
            this.ProductAttributeslabel.AutoSize = true;
            this.ProductAttributeslabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ProductAttributeslabel.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductAttributeslabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.ProductAttributeslabel.Location = new System.Drawing.Point(49, 44);
            this.ProductAttributeslabel.Name = "ProductAttributeslabel";
            this.ProductAttributeslabel.Size = new System.Drawing.Size(121, 30);
            this.ProductAttributeslabel.TabIndex = 66;
            this.ProductAttributeslabel.Text = "Project Type";
            // 
            // ProjectType
            // 
            this.ProjectType.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonStandalone;
            this.ProjectType.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ListItem;
            this.ProjectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProjectType.DropDownWidth = 158;
            this.ProjectType.Items.AddRange(new object[] {
            "auto",
            "organic",
            "semidetached",
            "embedded"});
            this.ProjectType.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this.ProjectType.Location = new System.Drawing.Point(54, 87);
            this.ProjectType.MinimumSize = new System.Drawing.Size(0, 30);
            this.ProjectType.Name = "ProjectType";
            this.ProjectType.Palette = this.kryptonPalette2;
            this.ProjectType.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ProjectType.Size = new System.Drawing.Size(169, 30);
            this.ProjectType.StateActive.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ProjectType.StateActive.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ProjectType.StateActive.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ProjectType.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ProjectType.StateActive.ComboBox.Content.Color1 = System.Drawing.Color.White;
            this.ProjectType.StateActive.ComboBox.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.ProjectType.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ProjectType.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ProjectType.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ProjectType.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ProjectType.StateCommon.ComboBox.Border.Rounding = 5;
            this.ProjectType.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.White;
            this.ProjectType.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.ProjectType.StateCommon.DropBack.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ProjectType.StateCommon.DropBack.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ProjectType.StateCommon.DropBack.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.ProjectType.StateCommon.DropBack.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ProjectType.StateCommon.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ProjectType.StateCommon.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ProjectType.StateCommon.Item.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ProjectType.StateCommon.Item.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ProjectType.StateCommon.Item.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ProjectType.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ProjectType.StateCommon.Item.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ProjectType.StateCommon.Item.Content.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.ProjectType.StateCommon.Item.Content.DrawFocus = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.ProjectType.StateCommon.Item.Content.LongText.Color1 = System.Drawing.Color.White;
            this.ProjectType.StateCommon.Item.Content.LongText.Color2 = System.Drawing.Color.White;
            this.ProjectType.StateCommon.Item.Content.LongText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.ProjectType.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.ProjectType.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.ProjectType.StateCommon.Item.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.ProjectType.StateNormal.Item.Content.DrawFocus = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.ProjectType.StateNormal.Item.Content.LongText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.ProjectType.TabIndex = 68;
            // 
            // kryptonPalette2
            // 
            this.kryptonPalette2.ButtonSpecs.DropDown.ColorMap = System.Drawing.Color.SaddleBrown;
            this.kryptonPalette2.ButtonSpecs.DropDown.Image = global::COCOMO_Calculator.Properties.Resources.mc_green;
            this.kryptonPalette2.ButtonSpecs.FormClose.Image = global::COCOMO_Calculator.Properties.Resources.mc_red;
            this.kryptonPalette2.ButtonSpecs.FormClose.ImageStates.ImagePressed = global::COCOMO_Calculator.Properties.Resources.sign_error_icon;
            this.kryptonPalette2.ButtonSpecs.FormClose.ImageStates.ImageTracking = global::COCOMO_Calculator.Properties.Resources.sign_error_icon;
            this.kryptonPalette2.ButtonSpecs.FormMax.Image = global::COCOMO_Calculator.Properties.Resources.mc_yellw;
            this.kryptonPalette2.ButtonSpecs.FormMax.ImageStates.ImagePressed = global::COCOMO_Calculator.Properties.Resources.mc_yellw;
            this.kryptonPalette2.ButtonSpecs.FormMax.ImageStates.ImageTracking = global::COCOMO_Calculator.Properties.Resources.mc_yellw;
            this.kryptonPalette2.ButtonSpecs.FormMin.Image = global::COCOMO_Calculator.Properties.Resources.mc_green;
            this.kryptonPalette2.ButtonSpecs.FormMin.ImageStates.ImagePressed = global::COCOMO_Calculator.Properties.Resources.mc_green;
            this.kryptonPalette2.ButtonSpecs.FormMin.ImageStates.ImageTracking = global::COCOMO_Calculator.Properties.Resources.mc_green;
            this.kryptonPalette2.ButtonSpecs.FormRestore.Image = global::COCOMO_Calculator.Properties.Resources.mc_yellw;
            this.kryptonPalette2.ButtonSpecs.FormRestore.ImageStates.ImagePressed = global::COCOMO_Calculator.Properties.Resources.mc_yellw;
            this.kryptonPalette2.ButtonSpecs.FormRestore.ImageStates.ImageTracking = global::COCOMO_Calculator.Properties.Resources.mc_yellw;
            this.kryptonPalette2.ButtonStyles.ButtonCustom1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonCustom1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.kryptonPalette2.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.kryptonPalette2.ButtonStyles.ButtonListItem.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.OverrideDefault.Content.Image.ImageColorMap = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.OverrideDefault.Content.Image.ImageColorTo = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.OverrideDefault.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.OverrideDefault.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.OverrideFocus.Content.Image.ImageColorMap = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.OverrideFocus.Content.Image.ImageColorTo = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCheckedNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCheckedNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCheckedNormal.Content.Image.ImageColorMap = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCheckedNormal.Content.Image.ImageColorTo = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCheckedNormal.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCheckedNormal.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCheckedNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCheckedNormal.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCheckedPressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCheckedPressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCheckedPressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCheckedPressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCheckedPressed.Content.Image.ImageColorMap = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCheckedPressed.Content.Image.ImageColorTo = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCheckedPressed.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCheckedPressed.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCheckedPressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCheckedPressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCheckedTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCheckedTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCheckedTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCheckedTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCheckedTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCheckedTracking.Content.Image.ImageColorMap = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCheckedTracking.Content.Image.ImageColorTo = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCheckedTracking.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCheckedTracking.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCheckedTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCheckedTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StatePressed.Content.Image.ImageColorMap = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StatePressed.Content.Image.ImageColorTo = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StatePressed.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StatePressed.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateTracking.Content.Image.ImageColorMap = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateTracking.Content.Image.ImageColorTo = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateTracking.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateTracking.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateTracking.Content.LongText.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Form;
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.ButtonStyles.ButtonListItem.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(224)))), ((int)(((byte)(105)))));
            this.kryptonPalette2.FormStyles.FormMain.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.FormStyles.FormMain.StateActive.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.FormStyles.FormMain.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.FormStyles.FormMain.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.FormStyles.FormMain.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.FormStyles.FormMain.StateActive.Border.Rounding = 0;
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.FormStyles.FormMain.StateCommon.Border.Rounding = 0;
            this.kryptonPalette2.FormStyles.FormMain.StateInactive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.FormStyles.FormMain.StateInactive.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.FormStyles.FormMain.StateInactive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.FormStyles.FormMain.StateInactive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPalette2.FormStyles.FormMain.StateInactive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.kryptonPalette2.FormStyles.FormMain.StateInactive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.FormStyles.FormMain.StateInactive.Border.Rounding = 0;
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.Border.Rounding = 12;
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Normal;
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.kryptonPalette2.HeaderStyles.HeaderForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            // 
            // Step1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1172, 703);
            this.Controls.Add(this.ProjectType);
            this.Controls.Add(this.ProductAttributeslabel);
            this.Controls.Add(this.KOLC_Value);
            this.Controls.Add(this.TDEV_Calculate);
            this.Controls.Add(this.EffortCalculate);
            this.Controls.Add(this.NextStep);
            this.Controls.Add(this.TDEVResult);
            this.Controls.Add(this.EffortResult);
            this.Controls.Add(this.TdevLabel);
            this.Controls.Add(this.EffortLabel);
            this.Controls.Add(this.KolcLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Step1";
            this.Palette = this.kryptonPalette2;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cocomo Calculator";
            this.Load += new System.EventHandler(this.Step1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TdevLabel;
        private System.Windows.Forms.Label EffortLabel;
        private System.Windows.Forms.Label KolcLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox EffortResult;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TDEVResult;
        private ComponentFactory.Krypton.Toolkit.KryptonButton NextStep;
        private ComponentFactory.Krypton.Toolkit.KryptonButton EffortCalculate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton TDEV_Calculate;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox KOLC_Value;
        private System.Windows.Forms.Label ProductAttributeslabel;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ProjectType;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette2;
    }
}