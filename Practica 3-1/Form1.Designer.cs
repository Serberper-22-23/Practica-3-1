namespace Practica_3_1
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.txtTelegrama = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.bCalcular = new System.Windows.Forms.Button();
			this.Texto = new System.Windows.Forms.Label();
			this.cbUrgente = new System.Windows.Forms.CheckBox();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtTelegrama
			// 
			this.txtTelegrama.Location = new System.Drawing.Point(172, 66);
			this.txtTelegrama.Multiline = true;
			this.txtTelegrama.Name = "txtTelegrama";
			this.txtTelegrama.Size = new System.Drawing.Size(457, 280);
			this.txtTelegrama.TabIndex = 0;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// bCalcular
			// 
			this.bCalcular.Location = new System.Drawing.Point(554, 417);
			this.bCalcular.Name = "bCalcular";
			this.bCalcular.Size = new System.Drawing.Size(75, 23);
			this.bCalcular.TabIndex = 3;
			this.bCalcular.Text = "Calcular";
			this.bCalcular.UseVisualStyleBackColor = true;
			this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
			// 
			// Texto
			// 
			this.Texto.AutoSize = true;
			this.Texto.Location = new System.Drawing.Point(169, 50);
			this.Texto.Name = "Texto";
			this.Texto.Size = new System.Drawing.Size(34, 13);
			this.Texto.TabIndex = 4;
			this.Texto.Text = "Texto";
			// 
			// cbUrgente
			// 
			this.cbUrgente.AutoSize = true;
			this.cbUrgente.Location = new System.Drawing.Point(172, 376);
			this.cbUrgente.Name = "cbUrgente";
			this.cbUrgente.Size = new System.Drawing.Size(70, 17);
			this.cbUrgente.TabIndex = 5;
			this.cbUrgente.Text = "Urgente?";
			this.cbUrgente.UseVisualStyleBackColor = true;
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(211, 419);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(100, 20);
			this.txtPrecio.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(168, 422);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Coste:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 471);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.cbUrgente);
			this.Controls.Add(this.Texto);
			this.Controls.Add(this.bCalcular);
			this.Controls.Add(this.txtTelegrama);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtTelegrama;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Button bCalcular;
		private System.Windows.Forms.Label Texto;
		private System.Windows.Forms.CheckBox cbUrgente;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.Label label1;
	}
}

