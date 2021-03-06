﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku_solver
{
    /// <summary>
    /// Klasa okna głównego.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Metoda wykonywana podczas inicjalizacji okna głównego.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// Metoda ogarniczająca wpisaywanie większej ilości znaków do pól edycyjnych w sudoku.
        /// </summary>
        /// <param name="tb">Pole edycyjne dla którego następuje usunięcie niepotrzebnych znaków.</param>
        void limitLengthToOne(TextBox tb)
        {
            String value = tb.Text;
            if (value.Length > 1)
            {
                tb.Text = value.Substring(0, 1);
            }
        }
        /// <summary>
        /// Metoda czyszcząca wszystkie pola wprowadzania danych.
        /// </summary>
        void CleanFields()
        {
            textBox0x0.Text = "";
            textBox0x1.Text = "";
            textBox0x2.Text = "";
            textBox0x3.Text = "";
            textBox0x4.Text = "";
            textBox0x5.Text = "";
            textBox0x6.Text = "";
            textBox0x7.Text = "";
            textBox0x8.Text = "";
            textBox1x0.Text = "";
            textBox1x1.Text = "";
            textBox1x2.Text = "";
            textBox1x3.Text = "";
            textBox1x4.Text = "";
            textBox1x5.Text = "";
            textBox1x6.Text = "";
            textBox1x7.Text = "";
            textBox1x8.Text = "";
            textBox2x0.Text = "";
            textBox2x1.Text = "";
            textBox2x2.Text = "";
            textBox2x3.Text = "";
            textBox2x4.Text = "";
            textBox2x5.Text = "";
            textBox2x6.Text = "";
            textBox2x7.Text = "";
            textBox2x8.Text = "";
            textBox3x0.Text = "";
            textBox3x1.Text = "";
            textBox3x2.Text = "";
            textBox3x3.Text = "";
            textBox3x4.Text = "";
            textBox3x5.Text = "";
            textBox3x6.Text = "";
            textBox3x7.Text = "";
            textBox3x8.Text = "";
            textBox4x0.Text = "";
            textBox4x1.Text = "";
            textBox4x2.Text = "";
            textBox4x3.Text = "";
            textBox4x4.Text = "";
            textBox4x5.Text = "";
            textBox4x6.Text = "";
            textBox4x7.Text = "";
            textBox4x8.Text = "";
            textBox5x0.Text = "";
            textBox5x1.Text = "";
            textBox5x2.Text = "";
            textBox5x3.Text = "";
            textBox5x4.Text = "";
            textBox5x5.Text = "";
            textBox5x6.Text = "";
            textBox5x7.Text = "";
            textBox5x8.Text = "";
            textBox6x0.Text = "";
            textBox6x1.Text = "";
            textBox6x2.Text = "";
            textBox6x3.Text = "";
            textBox6x4.Text = "";
            textBox6x5.Text = "";
            textBox6x6.Text = "";
            textBox6x7.Text = "";
            textBox6x8.Text = "";
            textBox7x0.Text = "";
            textBox7x1.Text = "";
            textBox7x2.Text = "";
            textBox7x3.Text = "";
            textBox7x4.Text = "";
            textBox7x5.Text = "";
            textBox7x6.Text = "";
            textBox7x7.Text = "";
            textBox7x8.Text = "";
            textBox8x0.Text = "";
            textBox8x1.Text = "";
            textBox8x2.Text = "";
            textBox8x3.Text = "";
            textBox8x4.Text = "";
            textBox8x5.Text = "";
            textBox8x6.Text = "";
            textBox8x7.Text = "";
            textBox8x8.Text = "";

        }
        /// <summary>
        /// Metoda zwracająca wszystkie dane wpisane w pola edycyjne w postaci jednego obiektu klasy DataSet.
        /// </summary>
        /// <returns></returns>
        DataSet getDataFromSudoku()
        {
            DataSet dataSet = new DataSet();
            dataSet.sudokuData[0, 0] = getFieldValue(textBox0x0);
            dataSet.sudokuData[0, 1] = getFieldValue(textBox0x1);
            dataSet.sudokuData[0, 2] = getFieldValue(textBox0x2);
            dataSet.sudokuData[0, 3] = getFieldValue(textBox0x3);
            dataSet.sudokuData[0, 4] = getFieldValue(textBox0x4);
            dataSet.sudokuData[0, 5] = getFieldValue(textBox0x5);
            dataSet.sudokuData[0, 6] = getFieldValue(textBox0x6);
            dataSet.sudokuData[0, 7] = getFieldValue(textBox0x7);
            dataSet.sudokuData[0, 8] = getFieldValue(textBox0x8);
            dataSet.sudokuData[1, 0] = getFieldValue(textBox1x0);
            dataSet.sudokuData[1, 1] = getFieldValue(textBox1x1);
            dataSet.sudokuData[1, 2] = getFieldValue(textBox1x2);
            dataSet.sudokuData[1, 3] = getFieldValue(textBox1x3);
            dataSet.sudokuData[1, 4] = getFieldValue(textBox1x4);
            dataSet.sudokuData[1, 5] = getFieldValue(textBox1x5);
            dataSet.sudokuData[1, 6] = getFieldValue(textBox1x6);
            dataSet.sudokuData[1, 7] = getFieldValue(textBox1x7);
            dataSet.sudokuData[1, 8] = getFieldValue(textBox1x8);
            dataSet.sudokuData[2, 0] = getFieldValue(textBox2x0);
            dataSet.sudokuData[2, 1] = getFieldValue(textBox2x1);
            dataSet.sudokuData[2, 2] = getFieldValue(textBox2x2);
            dataSet.sudokuData[2, 3] = getFieldValue(textBox2x3);
            dataSet.sudokuData[2, 4] = getFieldValue(textBox2x4);
            dataSet.sudokuData[2, 5] = getFieldValue(textBox2x5);
            dataSet.sudokuData[2, 6] = getFieldValue(textBox2x6);
            dataSet.sudokuData[2, 7] = getFieldValue(textBox2x7);
            dataSet.sudokuData[2, 8] = getFieldValue(textBox2x8);
            dataSet.sudokuData[3, 0] = getFieldValue(textBox3x0);
            dataSet.sudokuData[3, 1] = getFieldValue(textBox3x1);
            dataSet.sudokuData[3, 2] = getFieldValue(textBox3x2);
            dataSet.sudokuData[3, 3] = getFieldValue(textBox3x3);
            dataSet.sudokuData[3, 4] = getFieldValue(textBox3x4);
            dataSet.sudokuData[3, 5] = getFieldValue(textBox3x5);
            dataSet.sudokuData[3, 6] = getFieldValue(textBox3x6);
            dataSet.sudokuData[3, 7] = getFieldValue(textBox3x7);
            dataSet.sudokuData[3, 8] = getFieldValue(textBox3x8);
            dataSet.sudokuData[4, 0] = getFieldValue(textBox4x0);
            dataSet.sudokuData[4, 1] = getFieldValue(textBox4x1);
            dataSet.sudokuData[4, 2] = getFieldValue(textBox4x2);
            dataSet.sudokuData[4, 3] = getFieldValue(textBox4x3);
            dataSet.sudokuData[4, 4] = getFieldValue(textBox4x4);
            dataSet.sudokuData[4, 5] = getFieldValue(textBox4x5);
            dataSet.sudokuData[4, 6] = getFieldValue(textBox4x6);
            dataSet.sudokuData[4, 7] = getFieldValue(textBox4x7);
            dataSet.sudokuData[4, 8] = getFieldValue(textBox4x8);
            dataSet.sudokuData[5, 0] = getFieldValue(textBox5x0);
            dataSet.sudokuData[5, 1] = getFieldValue(textBox5x1);
            dataSet.sudokuData[5, 2] = getFieldValue(textBox5x2);
            dataSet.sudokuData[5, 3] = getFieldValue(textBox5x3);
            dataSet.sudokuData[5, 4] = getFieldValue(textBox5x4);
            dataSet.sudokuData[5, 5] = getFieldValue(textBox5x5);
            dataSet.sudokuData[5, 6] = getFieldValue(textBox5x6);
            dataSet.sudokuData[5, 7] = getFieldValue(textBox5x7);
            dataSet.sudokuData[5, 8] = getFieldValue(textBox5x8);
            dataSet.sudokuData[6, 0] = getFieldValue(textBox6x0);
            dataSet.sudokuData[6, 1] = getFieldValue(textBox6x1);
            dataSet.sudokuData[6, 2] = getFieldValue(textBox6x2);
            dataSet.sudokuData[6, 3] = getFieldValue(textBox6x3);
            dataSet.sudokuData[6, 4] = getFieldValue(textBox6x4);
            dataSet.sudokuData[6, 5] = getFieldValue(textBox6x5);
            dataSet.sudokuData[6, 6] = getFieldValue(textBox6x6);
            dataSet.sudokuData[6, 7] = getFieldValue(textBox6x7);
            dataSet.sudokuData[6, 8] = getFieldValue(textBox6x8);
            dataSet.sudokuData[7, 0] = getFieldValue(textBox7x0);
            dataSet.sudokuData[7, 1] = getFieldValue(textBox7x1);
            dataSet.sudokuData[7, 2] = getFieldValue(textBox7x2);
            dataSet.sudokuData[7, 3] = getFieldValue(textBox7x3);
            dataSet.sudokuData[7, 4] = getFieldValue(textBox7x4);
            dataSet.sudokuData[7, 5] = getFieldValue(textBox7x5);
            dataSet.sudokuData[7, 6] = getFieldValue(textBox7x6);
            dataSet.sudokuData[7, 7] = getFieldValue(textBox7x7);
            dataSet.sudokuData[7, 8] = getFieldValue(textBox7x8);
            dataSet.sudokuData[8, 0] = getFieldValue(textBox8x0);
            dataSet.sudokuData[8, 1] = getFieldValue(textBox8x1);
            dataSet.sudokuData[8, 2] = getFieldValue(textBox8x2);
            dataSet.sudokuData[8, 3] = getFieldValue(textBox8x3);
            dataSet.sudokuData[8, 4] = getFieldValue(textBox8x4);
            dataSet.sudokuData[8, 5] = getFieldValue(textBox8x5);
            dataSet.sudokuData[8, 6] = getFieldValue(textBox8x6);
            dataSet.sudokuData[8, 7] = getFieldValue(textBox8x7);
            dataSet.sudokuData[8, 8] = getFieldValue(textBox8x8);
            return dataSet;
        }
        /// <summary>
        /// Metoda wyciągająca wpisaną cyfre w pojedynczego pola edycyjnego.
        /// </summary>
        /// <param name="tb">Pole edycyjne  zktórego wyciągane są dane.</param>
        /// <returns></returns>
        int getFieldValue(TextBox tb)
        {
            string text = tb.Text;
            if (text.Length > 1|| text.Length==0)
            {
                return 0;
            }
            else
            {
                int result;
                if (!Int32.TryParse(text,out result))
                {
                    return 0;
                }
                else
                {
                    return result;
                }
            }
        }
        /// <summary>
        /// Metoda wyświetlająca dane w polach edycyjnych.
        /// </summary>
        /// <param name="dataSet">Zbiór danych który jest wyświetlany przez metodę.</param>
        void SetFields(DataSet dataSet)
        {
            if (dataSet.sudokuData[0, 0] != null) { textBox0x0.Text = "" + dataSet.sudokuData[0, 0]; }
            if (dataSet.sudokuData[0, 1] != null) { textBox0x1.Text = "" + dataSet.sudokuData[0, 1]; }
            if (dataSet.sudokuData[0, 2] != null) { textBox0x2.Text = "" + dataSet.sudokuData[0, 2]; }
            if (dataSet.sudokuData[0, 3] != null) { textBox0x3.Text = "" + dataSet.sudokuData[0, 3]; }
            if (dataSet.sudokuData[0, 4] != null) { textBox0x4.Text = "" + dataSet.sudokuData[0, 4]; }
            if (dataSet.sudokuData[0, 5] != null) { textBox0x5.Text = "" + dataSet.sudokuData[0, 5]; }
            if (dataSet.sudokuData[0, 6] != null) { textBox0x6.Text = "" + dataSet.sudokuData[0, 6]; }
            if (dataSet.sudokuData[0, 7] != null) { textBox0x7.Text = "" + dataSet.sudokuData[0, 7]; }
            if (dataSet.sudokuData[0, 8] != null) { textBox0x8.Text = "" + dataSet.sudokuData[0, 8]; }
            if (dataSet.sudokuData[1, 0] != null) { textBox1x0.Text = "" + dataSet.sudokuData[1, 0]; }
            if (dataSet.sudokuData[1, 1] != null) { textBox1x1.Text = "" + dataSet.sudokuData[1, 1]; }
            if (dataSet.sudokuData[1, 2] != null) { textBox1x2.Text = "" + dataSet.sudokuData[1, 2]; }
            if (dataSet.sudokuData[1, 3] != null) { textBox1x3.Text = "" + dataSet.sudokuData[1, 3]; }
            if (dataSet.sudokuData[1, 4] != null) { textBox1x4.Text = "" + dataSet.sudokuData[1, 4]; }
            if (dataSet.sudokuData[1, 5] != null) { textBox1x5.Text = "" + dataSet.sudokuData[1, 5]; }
            if (dataSet.sudokuData[1, 6] != null) { textBox1x6.Text = "" + dataSet.sudokuData[1, 6]; }
            if (dataSet.sudokuData[1, 7] != null) { textBox1x7.Text = "" + dataSet.sudokuData[1, 7]; }
            if (dataSet.sudokuData[1, 8] != null) { textBox1x8.Text = "" + dataSet.sudokuData[1, 8]; }
            if (dataSet.sudokuData[2, 0] != null) { textBox2x0.Text = "" + dataSet.sudokuData[2, 0]; }
            if (dataSet.sudokuData[2, 1] != null) { textBox2x1.Text = "" + dataSet.sudokuData[2, 1]; }
            if (dataSet.sudokuData[2, 2] != null) { textBox2x2.Text = "" + dataSet.sudokuData[2, 2]; }
            if (dataSet.sudokuData[2, 3] != null) { textBox2x3.Text = "" + dataSet.sudokuData[2, 3]; }
            if (dataSet.sudokuData[2, 4] != null) { textBox2x4.Text = "" + dataSet.sudokuData[2, 4]; }
            if (dataSet.sudokuData[2, 5] != null) { textBox2x5.Text = "" + dataSet.sudokuData[2, 5]; }
            if (dataSet.sudokuData[2, 6] != null) { textBox2x6.Text = "" + dataSet.sudokuData[2, 6]; }
            if (dataSet.sudokuData[2, 7] != null) { textBox2x7.Text = "" + dataSet.sudokuData[2, 7]; }
            if (dataSet.sudokuData[2, 8] != null) { textBox2x8.Text = "" + dataSet.sudokuData[2, 8]; }
            if (dataSet.sudokuData[3, 0] != null) { textBox3x0.Text = "" + dataSet.sudokuData[3, 0]; }
            if (dataSet.sudokuData[3, 1] != null) { textBox3x1.Text = "" + dataSet.sudokuData[3, 1]; }
            if (dataSet.sudokuData[3, 2] != null) { textBox3x2.Text = "" + dataSet.sudokuData[3, 2]; }
            if (dataSet.sudokuData[3, 3] != null) { textBox3x3.Text = "" + dataSet.sudokuData[3, 3]; }
            if (dataSet.sudokuData[3, 4] != null) { textBox3x4.Text = "" + dataSet.sudokuData[3, 4]; }
            if (dataSet.sudokuData[3, 5] != null) { textBox3x5.Text = "" + dataSet.sudokuData[3, 5]; }
            if (dataSet.sudokuData[3, 6] != null) { textBox3x6.Text = "" + dataSet.sudokuData[3, 6]; }
            if (dataSet.sudokuData[3, 7] != null) { textBox3x7.Text = "" + dataSet.sudokuData[3, 7]; }
            if (dataSet.sudokuData[3, 8] != null) { textBox3x8.Text = "" + dataSet.sudokuData[3, 8]; }
            if (dataSet.sudokuData[4, 0] != null) { textBox4x0.Text = "" + dataSet.sudokuData[4, 0]; }
            if (dataSet.sudokuData[4, 1] != null) { textBox4x1.Text = "" + dataSet.sudokuData[4, 1]; }
            if (dataSet.sudokuData[4, 2] != null) { textBox4x2.Text = "" + dataSet.sudokuData[4, 2]; }
            if (dataSet.sudokuData[4, 3] != null) { textBox4x3.Text = "" + dataSet.sudokuData[4, 3]; }
            if (dataSet.sudokuData[4, 4] != null) { textBox4x4.Text = "" + dataSet.sudokuData[4, 4]; }
            if (dataSet.sudokuData[4, 5] != null) { textBox4x5.Text = "" + dataSet.sudokuData[4, 5]; }
            if (dataSet.sudokuData[4, 6] != null) { textBox4x6.Text = "" + dataSet.sudokuData[4, 6]; }
            if (dataSet.sudokuData[4, 7] != null) { textBox4x7.Text = "" + dataSet.sudokuData[4, 7]; }
            if (dataSet.sudokuData[4, 8] != null) { textBox4x8.Text = "" + dataSet.sudokuData[4, 8]; }
            if (dataSet.sudokuData[5, 0] != null) { textBox5x0.Text = "" + dataSet.sudokuData[5, 0]; }
            if (dataSet.sudokuData[5, 1] != null) { textBox5x1.Text = "" + dataSet.sudokuData[5, 1]; }
            if (dataSet.sudokuData[5, 2] != null) { textBox5x2.Text = "" + dataSet.sudokuData[5, 2]; }
            if (dataSet.sudokuData[5, 3] != null) { textBox5x3.Text = "" + dataSet.sudokuData[5, 3]; }
            if (dataSet.sudokuData[5, 4] != null) { textBox5x4.Text = "" + dataSet.sudokuData[5, 4]; }
            if (dataSet.sudokuData[5, 5] != null) { textBox5x5.Text = "" + dataSet.sudokuData[5, 5]; }
            if (dataSet.sudokuData[5, 6] != null) { textBox5x6.Text = "" + dataSet.sudokuData[5, 6]; }
            if (dataSet.sudokuData[5, 7] != null) { textBox5x7.Text = "" + dataSet.sudokuData[5, 7]; }
            if (dataSet.sudokuData[5, 8] != null) { textBox5x8.Text = "" + dataSet.sudokuData[5, 8]; }
            if (dataSet.sudokuData[6, 0] != null) { textBox6x0.Text = "" + dataSet.sudokuData[6, 0]; }
            if (dataSet.sudokuData[6, 1] != null) { textBox6x1.Text = "" + dataSet.sudokuData[6, 1]; }
            if (dataSet.sudokuData[6, 2] != null) { textBox6x2.Text = "" + dataSet.sudokuData[6, 2]; }
            if (dataSet.sudokuData[6, 3] != null) { textBox6x3.Text = "" + dataSet.sudokuData[6, 3]; }
            if (dataSet.sudokuData[6, 4] != null) { textBox6x4.Text = "" + dataSet.sudokuData[6, 4]; }
            if (dataSet.sudokuData[6, 5] != null) { textBox6x5.Text = "" + dataSet.sudokuData[6, 5]; }
            if (dataSet.sudokuData[6, 6] != null) { textBox6x6.Text = "" + dataSet.sudokuData[6, 6]; }
            if (dataSet.sudokuData[6, 7] != null) { textBox6x7.Text = "" + dataSet.sudokuData[6, 7]; }
            if (dataSet.sudokuData[6, 8] != null) { textBox6x8.Text = "" + dataSet.sudokuData[6, 8]; }
            if (dataSet.sudokuData[7, 0] != null) { textBox7x0.Text = "" + dataSet.sudokuData[7, 0]; }
            if (dataSet.sudokuData[7, 1] != null) { textBox7x1.Text = "" + dataSet.sudokuData[7, 1]; }
            if (dataSet.sudokuData[7, 2] != null) { textBox7x2.Text = "" + dataSet.sudokuData[7, 2]; }
            if (dataSet.sudokuData[7, 3] != null) { textBox7x3.Text = "" + dataSet.sudokuData[7, 3]; }
            if (dataSet.sudokuData[7, 4] != null) { textBox7x4.Text = "" + dataSet.sudokuData[7, 4]; }
            if (dataSet.sudokuData[7, 5] != null) { textBox7x5.Text = "" + dataSet.sudokuData[7, 5]; }
            if (dataSet.sudokuData[7, 6] != null) { textBox7x6.Text = "" + dataSet.sudokuData[7, 6]; }
            if (dataSet.sudokuData[7, 7] != null) { textBox7x7.Text = "" + dataSet.sudokuData[7, 7]; }
            if (dataSet.sudokuData[7, 8] != null) { textBox7x8.Text = "" + dataSet.sudokuData[7, 8]; }
            if (dataSet.sudokuData[8, 0] != null) { textBox8x0.Text = "" + dataSet.sudokuData[8, 0]; }
            if (dataSet.sudokuData[8, 1] != null) { textBox8x1.Text = "" + dataSet.sudokuData[8, 1]; }
            if (dataSet.sudokuData[8, 2] != null) { textBox8x2.Text = "" + dataSet.sudokuData[8, 2]; }
            if (dataSet.sudokuData[8, 3] != null) { textBox8x3.Text = "" + dataSet.sudokuData[8, 3]; }
            if (dataSet.sudokuData[8, 4] != null) { textBox8x4.Text = "" + dataSet.sudokuData[8, 4]; }
            if (dataSet.sudokuData[8, 5] != null) { textBox8x5.Text = "" + dataSet.sudokuData[8, 5]; }
            if (dataSet.sudokuData[8, 6] != null) { textBox8x6.Text = "" + dataSet.sudokuData[8, 6]; }
            if (dataSet.sudokuData[8, 7] != null) { textBox8x7.Text = "" + dataSet.sudokuData[8, 7]; }
            if (dataSet.sudokuData[8, 8] != null) { textBox8x8.Text = "" + dataSet.sudokuData[8, 8]; }
        }
        /// <summary>
        /// Metoda odpowiadająca za reakcje na kliknięcie w przycisk walidacji danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (Engine.IsDataValid(getDataFromSudoku()))
            {
                infoLabelSetValidInfo();
            }
            else
            {
                infoLabelSetNotValidInfo();
            }
        }
        /// <summary>
        /// Metoda czyszcząca wyświetlany komunikat.
        /// </summary>
        private void infoLabelClear()
        {
            info_label.Text = "";
        }
        /// <summary>
        /// Metoda wyświetlająca informacje o poprawności wprowadzonych danych.
        /// </summary>
        private void infoLabelSetValidInfo()
        {
            info_label.Text = "Data is valid";
            info_label.ForeColor = Color.Green;

        }
        /// <summary>
        /// Metoda wyświetlająca informacje o niepoprawności wprowadzonych danych.
        /// </summary>
        private void infoLabelSetNotValidInfo()
        {
            info_label.Text = "Data is not valid!";
            info_label.ForeColor = Color.Red;
        }
        /// <summary>
        /// Metoda wyświetlająca informacje o poprawnym rozwiązaniu łamigłówki.
        /// </summary>
        private void infoLabelSetSolvedInfo()
        {
            info_label.Text = "Sudoku solved!";
            info_label.ForeColor = Color.Green;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox0x0);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox1x0);
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox2x0);
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox2x1);
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox1x1);
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox0x1);
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox2x2);
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox1x2);
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox0x2);
        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox5x2);
        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox4x2);
        }
        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox3x2);
        }
        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox5x1);
        }
        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox4x1);
        }
        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox3x1);
        }
        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox5x0);
        }
        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox4x0);
        }
        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox3x0);
        }
        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox8x2);
        }
        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox7x2);
        }
        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox6x2);
        }
        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox8x1);
        }
        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox7x1);
        }
        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox6x1);
        }
        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox8x0);
        }
        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox7x0);
        }
        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox6x0);
        }
        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox8x5);
        }
        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox7x5);
        }
        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox6x5);
        }
        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox8x4);
        }
        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox7x4);
        }
        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox6x4);
        }
        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox8x3);
        }
        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox7x3);
        }
        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox6x3);
        }
        private void textBox37_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox5x5);
        }
        private void textBox38_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox4x5);
        }
        private void textBox39_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox3x5);
        }
        private void textBox40_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox5x4);
        }
        private void textBox41_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox4x4);
        }
        private void textBox42_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox3x4);
        }
        private void textBox43_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox5x3);
        }
        private void textBox44_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox4x3);
        }
        private void textBox45_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox3x3);
        }
        private void textBox46_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox2x5);
        }
        private void textBox47_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox1x5);
        }
        private void textBox48_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox0x5);
        }
        private void textBox49_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox2x4);
        }
        private void textBox50_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox1x4);
        }
        private void textBox51_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox0x4);
        }
        private void textBox52_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox2x3);
        }
        private void textBox53_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox1x3);
        }
        private void textBox54_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox0x3);
        }
        private void textBox55_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox8x8);
        }
        private void textBox56_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox7x8);
        }
        private void textBox57_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox6x8);
        }
        private void textBox58_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox8x7);
        }
        private void textBox59_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox7x7);
        }
        private void textBox60_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox6x7);
        }
        private void textBox61_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox8x6);
        }
        private void textBox62_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox7x6);
        }
        private void textBox63_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox6x6);
        }
        private void textBox64_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox5x8);
        }
        private void textBox65_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox4x8);
        }
        private void textBox66_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox3x8);
        }
        private void textBox67_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox5x7);
        }
        private void textBox68_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox4x7);
        }
        private void textBox69_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox3x7);
        }
        private void textBox70_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox5x6);
        }
        private void textBox71_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox4x6);
        }
        private void textBox72_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox3x6);
        }
        private void textBox73_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox2x8);
        }
        private void textBox74_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox1x8);
        }
        private void textBox75_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox0x8);
        }
        private void textBox76_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox2x7);
        }
        private void textBox77_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox1x7);
        }
        private void textBox78_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox0x7);
        }
        private void textBox79_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox2x6);
        }
        private void textBox80_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox1x6);
        }
        private void textBox81_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox0x6);
        }
        /// <summary>
        /// Metoda odpowiadająca za reakcje na kliknięcie przycisku czyszczenia tablicy.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            CleanFields();
            infoLabelClear();
        }
        /// <summary>
        /// Metoda odpowiedzialna za reakcję na kliknięcie przycisku rozwiązującego sudoku.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            DataSet ds = getDataFromSudoku();
            if (Engine.IsDataValid(ds))
            {
                infoLabelSetSolvedInfo();
                SetFields(Engine.ComputeResult(ds));
            }
            else
            {
                infoLabelSetNotValidInfo();
            }
            
        }

        private void textBox3x0_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox3x0);
        }

        private void textBox4x0_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox4x0);
        }

        private void textBox5x0_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox5x0);
        }

        private void textBox3x1_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox3x1);
        }

        private void textBox6x0_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox6x0);
        }

        private void textBox7x0_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox7x0);
        }

        private void textBox8x0_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox8x0);
        }

        private void textBox6x1_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox6x1);
        }

        private void textBox7x1_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox7x1);
        }

        private void textBox8x1_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox8x1);
        }

        private void textBox6x2_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox6x2);
        }

        private void textBox7x2_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox7x2);
        }

        private void textBox8x2_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox8x2);
        }

        private void textBox0x3_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox0x3);
        }

        private void textBox1x3_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox1x3);
        }

        private void textBox2x3_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox2x3);
        }

        private void textBox0x4_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox0x4);
        }

        private void textBox1x4_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox1x4);
        }

        private void textBox2x4_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox2x4);
        }

        private void textBox0x5_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox0x5);
        }

        private void textBox1x5_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox1x5);
        }

        private void textBox2x5_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox2x5);
        }

        private void textBox3x3_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox3x3);
        }

        private void textBox4x3_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox4x3);
        }

        private void textBox5x3_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox5x3);
        }

        private void textBox3x4_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox3x4);
        }

        private void textBox4x4_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox4x4);
        }

        private void textBox5x4_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox5x4);
        }

        private void textBox3x5_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox3x5);
        }

        private void textBox4x5_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox4x5);
        }

        private void textBox5x5_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox5x5);
        }

        private void textBox6x3_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox6x3);
        }

        private void textBox7x3_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox7x3);
        }

        private void textBox8x3_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox8x3);
        }

        private void textBox6x4_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox6x4);
        }

        private void textBox7x4_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox7x4);
        }

        private void textBox8x4_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox8x4);
        }

        private void textBox6x5_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox6x5);
        }

        private void textBox7x5_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox7x5);
        }

        private void textBox8x5_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox8x5);
        }

        private void textBox0x6_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox0x6);
        }

        private void textBox1x6_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox1x6);
        }

        private void textBox2x6_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox2x6);
        }

        private void textBox0x7_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox0x7);
        }

        private void textBox1x7_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox1x7);
        }

        private void textBox2x7_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox2x7);
        }

        private void textBox0x8_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox0x8);
        }

        private void textBox1x8_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox1x8);
        }

        private void textBox2x8_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox2x8);
        }

        private void textBox3x6_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox3x6);
        }

        private void textBox4x6_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox4x6);
        }

        private void textBox5x6_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox5x6);
        }

        private void textBox3x7_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox3x7);
        }

        private void textBox4x7_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox4x7);
        }

        private void textBox5x7_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox5x7);
        }

        private void textBox3x8_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox3x8);
        }

        private void textBox4x8_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox4x8);
        }

        private void textBox5x8_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox5x8);
        }

        private void textBox6x6_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox6x6);
        }

        private void textBox7x6_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox7x6);
        }

        private void textBox8x6_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox8x6);
        }

        private void textBox6x7_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox6x7);
        }

        private void textBox7x7_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox7x7);
        }

        private void textBox8x7_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox8x7);
        }

        private void textBox6x8_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox6x8);
        }

        private void textBox7x8_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox7x8);
        }

        private void textBox8x8_TextChanged(object sender, EventArgs e)
        {
            limitLengthToOne(textBox8x8);
        }
    }
}