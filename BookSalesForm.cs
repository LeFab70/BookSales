/*
    Programmeur:    Fabrice
    Date:           Janvier
  
    Solution:       BookSales.sln
    Projet:         BookSales.csproj
    Classe:         BookSalesForm.cs  {BookSales}
  
    But:			Produire la facture de transactions de vente de livres dans une Librairie.
  
    Entrées:		Transaction de vente: Nombre de copies du livre acheté, le titre du livre et le prix unitaire de chaque livre.
  
    Traitement:	    Après avoir validé les données de la transaction de vente, 
   			        calculer, afficher et imprimer la facture.
   			
    Sorties:		Prix total, le rabais et le prix après rabais.
  				    Imprimer la transaction de vente et la facture.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookSales
{
    public partial class BookSalesForm : Form
    {
        #region Déclarations des champs privees de la classe

        //champs privées

        //Déclaration des constantes
        private const decimal DISCOUNT_RATE = 0.15m;

        //Déclaration des variables
        private decimal totalPrice;
        private decimal discount;
        private decimal priceAfterDiscount;
        private int numberOfBooks;
        private decimal totalVentes = 0.0M;
        private int nbreTotalLivreVendu = 0;
        //private DateTime dateOfSale=new DateTime();

        #endregion

        #region Initialisation de la classe



        #endregion

        #region constructeur de la classe



        #endregion

        #region getters et setters



        #endregion

        #region methodes de la classe

        //Calculer le prix total de la transaction de vente
        decimal calculateTotalPrice(int numberOfBooks, decimal pricePerBook)
        {
            return numberOfBooks * pricePerBook;
        }
        //Calculer le rabais
        decimal calculateDiscount(decimal totalPrice)
        {
            return totalPrice * DISCOUNT_RATE;
        }
        //Calculer le prix après rabais
        decimal calculatePriceAfterDiscount(decimal totalPrice, decimal discount)
        {
            return totalPrice - discount;
        }

        //Reset les champs de la transaction de vente
        void clearSale()
        {
            quantityTextBox.Clear();
            priceTextBox.Clear();
            titleTextBox.Clear();
            extendedPriceTextBox.Clear();
            discountTextBox.Clear();
            discountedPriceTextBox.Clear();
            titleTextBox.Focus(); //focus sur le champ titre pour recommencer 
           // titleTextBox.SelectAll();//selectionner tout le texte dans le champ titre
        }
        #endregion


        public BookSalesForm()
        {
            InitializeComponent();
        }

        #region exit application
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region calculate transaction
        private void calculateButton_Click(object sender, EventArgs e)
        {
            //TODO: Valider les données de la transaction de vente
            try
            {
                numberOfBooks = int.Parse(quantityTextBox.Text);
                decimal pricePerBook = decimal.Parse(priceTextBox.Text);
                string title = titleTextBox.Text;
                //Calculer le prix total de la transaction de vente
                totalPrice = calculateTotalPrice(numberOfBooks, pricePerBook);
                extendedPriceTextBox.Text = totalPrice.ToString("c");
                //Calculer le rabais
                discount = calculateDiscount(totalPrice);
                discountTextBox.Text = discount.ToString("c");
                //Calculer le prix après rabais
                priceAfterDiscount = calculatePriceAfterDiscount(totalPrice, discount);
                discountedPriceTextBox.Text = priceAfterDiscount.ToString("c");
            }
            catch(FormatException ex) //catch exception si les données entrées ne sont pas valides exception personnalisée
            {
                MessageBox.Show("Veuillez entrer des données valides pour la transaction de vente");
            }
    
           
            catch (Exception ex) //catch exception generale
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region reset form
        private void clearSaleButton_Click(object sender, EventArgs e)
        {
           clearSale();

        }
        #endregion

        #region print transaction
        Bitmap memoryImage;
        private void printFormButton_Click(object sender, EventArgs e)
        {
            //TODO: Imprimer la transaction de vente et la facture
            try
            {
                printPreviewDialog1.ShowDialog();
                printDialog1.Document = printDocument1;
                //if (printDialog1.ShowDialog()==DialogResult.OK)
                //{
                //    printDocument1.Print();
                //}
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string msgToPrint = "Facture Date " + new DateTime() + Environment.NewLine + "\t Livre : " + titleTextBox.Text
                + Environment.NewLine + "\t Quantity: " + quantityTextBox.Text
                + Environment.NewLine + "\t PU : " + priceTextBox.Text
                + Environment.NewLine + "\t _________________________________"
                + Environment.NewLine + "\t Prix total avant rabais: " + extendedPriceTextBox.Text
                + Environment.NewLine + "\t Rabais: " + discountTextBox.Text
                + Environment.NewLine + "\t _________________________________"
                + Environment.NewLine + "\t Prix total apres rabais: " + discountedPriceTextBox.Text;
            e.Graphics.DrawString(msgToPrint,new Font("Arial",12),Brushes.Black,150,125);
        }

        private void BookSalesForm_Load(object sender, EventArgs e)
        {
            timeDayLabel.Text = DateTime.Now.ToLongDateString();
            timeDayLabel.Text = DateTime.Today.ToString("D");
        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            nbreTotalLivreVendu ++;
            totalVentes += priceAfterDiscount;
            MessageBox.Show("Nombre total de livres vendus: " + nbreTotalLivreVendu + "\n" + "Total des ventes: " + totalVentes.ToString("c"));
        }
    }
}
