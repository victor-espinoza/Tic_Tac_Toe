//Victor Espinoza
//CECS 475 - Application Programming using .NET
//Assignment #1 - Tic Tac Toe
//Due: 1/26/16

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CECS_475_Lab1 {
   class Program {
      static void Main(string[] args) {
         //initialize new Tic Tac Toe object
         TicTacToe game = new TicTacToe();
         //print out the board
         game.PrintBoard();
         //start playing a game of Tic Tac Toe
         game.Play();
      }//close main(...)
   }//close class Program
}//close namespace CECS_475_Lab1
