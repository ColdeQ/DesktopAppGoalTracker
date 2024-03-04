using System;



/*Class defines long term goals, it has a start date and an end date. Contains a list with sub goals.
 * Todo:
 *  How to quantiy goal as "reached"? Time spent? Sub goal reaached? Interface, abstract class?
 *  
 *  
 *  
 *  
 *  
 *  
 *  
 *  
 */
public class MainGoal
{
	DateTime starDate; //Changeable
	DateTime endDate; // Changeable
	List<SubGoal> list_subgoals = new List<SubGoal>(); 
	long timeSpent = 0; // int = 68 years? 

	public MainGoal(DateTime startDate, DateTime endDate)
	{
		this.starDate = starDate;
		this.endDate = endDate;
	}
}
