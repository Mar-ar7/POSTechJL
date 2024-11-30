namespace POSTechJL
{
    partial class InvoiceForm
    {
        /// <summary> 
        /// Variable del diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">Indica si los recursos administrados deben ser eliminados.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary> 
        /// Método requerido para la inicialización del diseñador.
        /// No se puede modificar el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInvoiceDetails = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtInvoiceDetails
            // 
            this.txtInvoiceDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInvoiceDetails.Font = new System.Drawing.Font("Courier New", 10F);
            this.txtInvoiceDetails.Location = new System.Drawing.Point(0, 0);
            this.txtInvoiceDetails.Multiline = true;
            this.txtInvoiceDetails.Name = "txtInvoiceDetails";
            this.txtInvoiceDetails.ReadOnly = true;
            this.txtInvoiceDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInvoiceDetails.Size = new System.Drawing.Size(844, 497);
            this.txtInvoiceDetails.TabIndex = 0;
            // 
            // InvoiceForm
            // 
            this.ClientSize = new System.Drawing.Size(844, 497);
            this.Controls.Add(this.txtInvoiceDetails);
            this.Name = "InvoiceForm";
            this.Text = "Factura de Venta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInvoiceDetails;
    }
}
