﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banmex.AddForms
{
    public partial class AddTransaction : Form
    {
        Class.Connection Connection;

        public AddTransaction(Class.Connection Connection)
        {
            InitializeComponent();

            this.Connection = Connection;

            //Ajustar el contenido de la tabla al tamaño del dataGridView
            origenDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            destinationGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void loadOrigenData()
        {
            Connection.OpenConnection();

            //se genera una lista con todos los clientes activos
            origenDataGridView.DataSource = Class.Client.showAllClients(Connection.myConnection);

            //se establecen los nombres de cabecera para las columnas
            this.origenDataGridView.Columns[0].HeaderCell.Value = "ID";
            this.origenDataGridView.Columns[1].HeaderCell.Value = "Nombre";
            this.origenDataGridView.Columns[2].HeaderCell.Value = "Apellido";
            this.origenDataGridView.Columns[3].Visible = false;
            this.origenDataGridView.Columns[4].Visible = false;
            this.origenDataGridView.Columns[5].Visible = false;
            this.origenDataGridView.Columns[6].Visible = false;

            Connection.CloseConnection();
        }

        private void loadDestinationData()
        {
            Connection.OpenConnection();

            //se genera una lista con todos los clientes activos
            destinationGridView.DataSource = Class.Client.showAllClients(Connection.myConnection);

            //se establecen los nombres de cabecera para las columnas
            this.destinationGridView.Columns[0].HeaderCell.Value = "ID";
            this.destinationGridView.Columns[1].HeaderCell.Value = "Nombre";
            this.destinationGridView.Columns[2].HeaderCell.Value = "Apellido";
            this.destinationGridView.Columns[3].Visible = false;
            this.destinationGridView.Columns[4].Visible = false;
            this.destinationGridView.Columns[5].Visible = false;
            this.destinationGridView.Columns[6].Visible = false;

            Connection.CloseConnection();
        }

        private void AddTransaction_Load(object sender, EventArgs e)
        {
            loadOrigenData();
            loadDestinationData();
        }
    }
}
