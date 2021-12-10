using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04._12._21
{
    class BankAccount
    {
		public enum Type
		{
			Current = 1,
			Saving
		}

		private readonly Type accountType;
		private readonly int number;
		private double balance;
		private int index;
		static int indexer = 0;

		public Type TypeOfAcc //Readonly property (type)
		{
			get { return accountType; }
		}
		public int NumberOfAcc //Readonly property (number)
		{
			get { return number; }
		}

		public BankAccount()
		{
			//Empty
			index = indexer++;
		}
		public BankAccount(double balance)
		{
			this.balance = balance;
			index = indexer++;
		}
		public BankAccount(Type accountType)
		{
			this.accountType = accountType;
			index = indexer++;
		}
		public BankAccount(int number)
		{
			this.number = number;
			index = indexer++;
		}
		public BankAccount(Type accountType, int number)
		{
			this.number = number;
			this.accountType = accountType;
			index = indexer++;
		}
		public BankAccount(Type accountType, double balance)
		{
			this.balance = balance;
			this.accountType = accountType;
			index = indexer++;
		}
		public BankAccount(double balance, int number)
		{
			this.balance = balance;
			this.number = number;
			index = indexer++;
		}
		public BankAccount(double balance, int number, Type accountType)
		{
			this.balance = balance;
			this.number = number;
			this.accountType = accountType;
			index = indexer++;
		}

		public static bool operator ==(BankAccount Acc1, BankAccount Acc2) //Переопределение ==
		{
			return Acc1.accountType == Acc2.accountType && Acc1.balance == Acc2.balance;
		}

		public static bool operator !=(BankAccount Acc1, BankAccount Acc2) //Переопределение !=
		{
			return !(Acc1.accountType == Acc2.accountType && Acc1.balance == Acc2.balance);
		}
		public override bool Equals(object acc) //Переопределение Equals
		{
			if (acc is BankAccount)
			{
				return this == (acc as BankAccount);
			}
			else
			{
				return false;
			}
		}
		public override int GetHashCode() //Переопределение GetHashCode
		{
			return base.GetHashCode();
		}
		public override string ToString() //Переопределение ToString
		{
			return $"Тип счёта: {accountType}\nБаланс счёта: {balance}\nИндекс счёта: {index}";
		}
	}
}
