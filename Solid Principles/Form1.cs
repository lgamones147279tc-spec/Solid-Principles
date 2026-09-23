using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Solid_Principles.Models;
using Solid_Principles.Repositories;
using Solid_Principles.Services;
using Solid_Principles.Services.Discount;

namespace Solid_Principles
{
    public partial class Form1 : Form
    {
        private decimal total;

        private readonly IOrderRepository orderRepository;
        private readonly IInvoiceEmailer invoiceEmailer;
        private readonly IOrderPrinter orderPrinter;
        private readonly OrderCalculator calculator;

        public Form1(
            IOrderRepository orderRepository,
            IInvoiceEmailer invoiceEmailer,
            IOrderPrinter orderPrinter,
            OrderCalculator calculator)
        {
            InitializeComponent();

            this.orderRepository = orderRepository;
            this.invoiceEmailer = invoiceEmailer;
            this.orderPrinter = orderPrinter;
            this.calculator = calculator;
        }

        private void btnCalculate_Click(
            object sender,
            EventArgs e)
        {

        }

        private IDiscountStrategy GetDiscountStrategy()
        {
            string selected =
                cmbDiscountType.SelectedItem?.ToString()
                ?? "None";

            switch (selected)
            {
                case "Student":
                    return new StudentDiscount();

                case "Senior":
                    return new SeniorDiscount();

                case "BlackFriday":
                    return new BlackFridayDiscount();

                default:
                    return new NoDiscount();
            }
        }

        private void btnSaveOrder_Click(
            object sender,
            EventArgs e)
        {

        }

        private void btnEmailInvoice_Click(
            object sender,
            EventArgs e)
        {
            invoiceEmailer.Send(
                txtCustomerEmail.Text,
                total);
        }

        private void btnPrint_Click(
            object sender,
            EventArgs e)
        {
            orderPrinter.Print(
                txtCustomerEmail.Text,
                total);
        }
    }
}