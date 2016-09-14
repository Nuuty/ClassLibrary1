using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Calculator
    {
		/// <summary>
		/// Property til lommeregnerens input felt
		/// </summary>
	    public String Input { get; set; }

		/// <summary>
		/// Property til at gemme det første indtastede input
		/// </summary>
	    public String FirstInput { get; set; }

		/// <summary>
		/// Property til at gemme det andet indtastede input
		/// </summary>
		public String SecondInput { get; set; }

		/// <summary>
		/// Property til at gemme den valgte operation
		/// </summary>
	    public char Operation { get; set; }

		/// <summary>
		/// Property til værdien af resultatet
		/// </summary>
	    public double Result { get; set; }
	    public Calculator()
	    {
		    
	    }

		/// <summary>
		/// Clearer alle tidligere indtastet værdier
		/// </summary>
	    public void Clear_click()
	    {
		    Input = String.Empty;
		    FirstInput = String.Empty;
			SecondInput = String.Empty;
		    Result = 0;
	    }

		/// <summary>
		/// Nul på lommeregneren, tilføjer 0 til input
		/// </summary>
	    public void Zero_click()
	    {
		    Input += "0";
	    }

		/// <summary>
		/// Et på lommeregneren, tilføjer 1 til input
		/// </summary>
		public void One_click()
		{
			Input += "1";
		}

		/// <summary>
		/// To på lommeregneren, tilføjer 2 til input
		/// </summary>
		public void Two_click()
		{
			Input += "2";
		}

		/// <summary>
		/// Tre på lommeregneren, tilføjer 3 til input
		/// </summary>
		public void Three_click()
		{
			Input += "3";
		}

		/// <summary>
		/// Fire på lommeregneren, tilføjer 4 til input
		/// </summary>
		public void Four_click()
		{
			Input += "4";
		}

		/// <summary>
		/// Fem på lommeregneren, tilføjer 5 til input
		/// </summary>
		public void Five_click()
		{
			Input += "5";
		}

		/// <summary>
		/// Seks på lommeregneren, tilføjer 6 til input
		/// </summary>
		public void Six_click()
		{
			Input += "6";
		}

		/// <summary>
		/// Syv på lommeregneren, tilføjer 7 til input
		/// </summary>
		public void Seven_click()
		{
			Input += "7";
		}

		/// <summary>
		/// Otte på lommeregneren, tilføjer 8 til input
		/// </summary>
		public void Eight_click()
		{
			Input += "8";
		}

		/// <summary>
		/// Ni på lommeregneren, tilføjer 9 til input
		/// </summary>
		public void Nine_click()
		{
			Input += "9";
		}

		/// <summary>
		/// Divider på lommeregneren, Gemmer input værdien i FirstInput, sætter et operations tegn og sætter Input til at være tom så du kan indtaste et nyt input
		/// </summary>
		public void Divide_click()
	    {
		    FirstInput = Input;
		    Operation = '/';
			Input = String.Empty;
	    }

		/// <summary>
		/// Gange på lommeregneren, Gemmer input værdien i FirstInput, sætter et operations tegn og sætter Input til at være tom så du kan indtaste et nyt input
		/// </summary>
		public void Multiply_click()
	    {
		    FirstInput = Input;
		    Operation = '*';
			Input = String.Empty;
	    }

		/// <summary>
		/// Plus på lommeregneren, Gemmer input værdien i FirstInput, sætter et operations tegn og sætter Input til at være tom så du kan indtaste et nyt input
		/// </summary>
		public void Plus_click()
	    {
			FirstInput = Input;
			Operation = '+';
			Input = String.Empty;
		}

		/// <summary>
		/// Minus på lommeregneren, Gemmer input værdien i FirstInput, sætter et operations tegn og sætter Input til at være tom så du kan indtaste et nyt input
		/// </summary>
		public void Minus_click()
	    {
			FirstInput = Input;
			Operation = '-';
			Input = String.Empty;
		}

		/// <summary>
		/// Equals på lommeregneren. Laver en udregning alt efter hvilke 2 inputs der er indtastet og hvilken operation der er blevet anvendt
		/// </summary>
	    public void Equals_click()
	    {
		    SecondInput = Input;
		    double num1, num2;
		    double.TryParse(FirstInput, out num1);
		    double.TryParse(SecondInput, out num2);
		    if (Operation == '+')
		    {
			    Result = num1 + num2;
				
		    }
		    if (Operation == '-')
		    {
			    Result = num1 - num2;
		    }
		    if (Operation == '*')
		    {
			    Result = num1*num2;
		    }
		    if (Operation == '/')
		    {
			    Result = num1/num2;
		    }
	    }

	}

}
