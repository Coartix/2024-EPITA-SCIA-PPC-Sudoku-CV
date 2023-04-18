using GeneticSharp;
using Sudoku.Shared;

namespace Sudoku.GeneticSharp
{
	public class OrderedCellsSolver : ISudokuSolver
	{
		public SudokuGrid Solve(SudokuGrid s)
		{
			var permutatedCellsChromosome = new SudokuOrderedCellsChromosome(s);
			
			var popSize = 400;

			// var crossover = new PartiallyMappedCrossover();
			var crossover = new CycleCrossover();
			// var crossover = new OrderedCrossover();
			// var crossover = new AlternatingPositionCrossover();
			// var crossover = new PositionBasedCrossover();
			
			
			//var mutation = new PartialShuffleMutation();
			//var mutation = new DisplacementMutation();
			var mutation = new TworsMutation();
			// var mutation = new ReverseSequenceMutation();
			// var mutation = new DisplacementMutation();

			var sdkBoard = SudokuTestHelper.Eval(permutatedCellsChromosome, crossover, mutation, s, popSize);

			return sdkBoard;
		}
	}

	public class PermCellsCycleTworsSolver : ISudokuSolver
	{
		public SudokuGrid Solve(SudokuGrid s)
		{
			var permutatedCellsChromosome = new SudokuPermutatedCellsChromosome(s);

			var popSize = 400;

			var crossover = new CycleCrossover();
			//var crossover = new OrderedCrossover();
			//var crossover = new PartiallyMappedCrossover();
			//var crossover = new PositionBasedCrossover();
			//var crossover = new AlternatingPositionCrossover();

			var mutation = new TworsMutation();
			//var mutation = new PartialShuffleMutation();
			//var mutation = new DisplacementMutation();
			//var mutation = new InsertionMutation();
			//var mutation = new ReverseSequenceMutation();


			// var mutation = new DisplacementMutation();

			var sdkBoard = SudokuTestHelper.Eval(permutatedCellsChromosome, crossover, mutation, s, popSize);

			return sdkBoard;
		}
	}

	public class PermCellsPartiallyMappedReverseSequenceSolver : ISudokuSolver
    {
        public SudokuGrid Solve(SudokuGrid s)
        {
	        var permutatedCellsChromosome = new SudokuPermutatedCellsChromosome(s);
			
			var popSize = 400;


			//var crossover = new CycleCrossover();
			//var crossover = new OrderedCrossover();
			var crossover = new PartiallyMappedCrossover();
			//var crossover = new PositionBasedCrossover();
			//var crossover = new AlternatingPositionCrossover();

			//var mutation = new TworsMutation();
			//var mutation = new PartialShuffleMutation();
			//var mutation = new DisplacementMutation();
			//var mutation = new InsertionMutation();
			var mutation = new ReverseSequenceMutation();


			// var mutation = new DisplacementMutation();

			var sdkBoard = SudokuTestHelper.Eval(permutatedCellsChromosome, crossover, mutation, s, popSize);

            return sdkBoard;
        }
    }

	public class PermCellsOrderedInsertionSolver : ISudokuSolver
	{
		public SudokuGrid Solve(SudokuGrid s)
		{
			var permutatedCellsChromosome = new SudokuPermutatedCellsChromosome(s);

			var popSize = 400;

			//var crossover = new CycleCrossover();
			var crossover = new OrderedCrossover();
			//var crossover = new PartiallyMappedCrossover();
			//var crossover = new PositionBasedCrossover();
			//var crossover = new AlternatingPositionCrossover();

			//var mutation = new TworsMutation();
			//var mutation = new PartialShuffleMutation();
			//var mutation = new DisplacementMutation();
			var mutation = new InsertionMutation();
			//var mutation = new ReverseSequenceMutation();


			// var mutation = new DisplacementMutation();

			var sdkBoard = SudokuTestHelper.Eval(permutatedCellsChromosome, crossover, mutation, s, popSize);

			return sdkBoard;
		}
	}



	public class PermSolver : ISudokuSolver
	{
		public SudokuGrid Solve(SudokuGrid s)
		{

			var permutatedCellsChromosome = new SudokuPermutationsChromosome(s);

			
			var popSize = 400;
			
			//var crossover = new CycleCrossover();
			// var crossover = new OrderedCrossover();
			var crossover = new UniformCrossover();
			
			// var mutation = new PartialShuffleMutation();
			var mutation = new UniformMutation();
		
			var sdkBoard = SudokuTestHelper.Eval(permutatedCellsChromosome, crossover, mutation, s, popSize);

			return sdkBoard;
		}
	}


	public class CellsSolver : ISudokuSolver
	{
		public SudokuGrid Solve(SudokuGrid s)
		{

			var cellsChromosome = new SudokuCellsChromosome(s);

		
			var popSize = 400;
			var crossover = new UniformCrossover();
			// var crossover = new OrderedCrossover();
			
			var mutation = new UniformMutation();
			// var mutation = new PartialShuffleMutation();

			var sdkBoard = SudokuTestHelper.Eval(cellsChromosome, crossover, mutation, s, popSize);

			return sdkBoard;

		}
	}


}