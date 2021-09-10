using System;
public class Calc
{
	public bool pontoFlutuante;
	public string valorAtual;
	public decimal valorAcumulado;
	public bool primeiroCaractere;
	public bool habilitaPonto;
	public bool permiteZero;
	private int tamanho;
	public char op;
	public decimal valorAtualNum;

	public Calc()
	{
		this.pontoFlutuante = false;
		this.primeiroCaractere = false;
		this.tamanho = 12;
		this.valorAtual = "";
		this.valorAcumulado = 0;
		this.habilitaPonto = false;
		this.permiteZero = false;
	}

	public void escreverNaTela(char simbolo)
	{
		if (valorAtual.Length <= 9)
		{
			if (simbolo >= '1' && simbolo <= '9')
			{
				this.valorAtual = this.valorAtual + simbolo;
				this.permiteZero = true;  // true significa 1
			}

			if (simbolo == '0' && this.permiteZero == true)
				this.valorAtual = this.valorAtual + simbolo;

			if (simbolo == '.' && habilitaPonto == false)
			{
				if (this.permiteZero == true)
				{
					this.valorAtual = this.valorAtual + simbolo;
				}
				else
				{
					this.valorAtual = "0.";
				}
				habilitaPonto = true;
			}
		}

	}

	public void raiz()
	{
		double temp;
		decimal temp2;
		if (this.valorAtual != "")
			this.valorAtualNum = Convert.ToDecimal(this.valorAtual);
		temp = Convert.ToDouble(valorAtualNum);
		temp2 = Convert.ToDecimal(Math.Sqrt(temp));
		valorAtual = temp2.ToString();
	}


	public void inverteSinal()
	{
		valorAtualNum = Convert.ToDecimal(this.valorAtual);
		valorAtualNum = -1 * valorAtualNum;
		valorAtual = valorAtualNum.ToString();
	}

	public void inverteOperacao()
	{
		valorAtualNum = Convert.ToDecimal(this.valorAtual);
		valorAtualNum = 1 / valorAtualNum;
		valorAtual = valorAtualNum.ToString();
	}

	public void gerarPi()
	{
		decimal valorAtualNum;
		valorAtualNum = Math.Round(Convert.ToDecimal(Math.PI), 10);
		this.valorAtual = valorAtualNum.ToString();
		this.valorAcumulado = 0;
	}

	public void operacao()
	{
		//Reconhecer a operacao
		switch (op)
		{
			case '+':
				{
					this.valorAcumulado = this.valorAcumulado + Convert.ToDecimal(this.valorAtual);
					break;
				}
			case '-':
				{
					this.valorAcumulado = this.valorAcumulado - Convert.ToDecimal(this.valorAtual);
					break;
				}
			case 'x':
				{
					this.valorAcumulado = this.valorAcumulado * Convert.ToDecimal(this.valorAtual);
					break;
				}
			case '/':
				{
					this.valorAcumulado = this.valorAcumulado / Convert.ToDecimal(this.valorAtual);
					break;
				}
			case '%':
				{
					this.valorAcumulado = this.valorAcumulado * Convert.ToDecimal(this.valorAtual) / 100;
					break;
				}

		}
	}


}

