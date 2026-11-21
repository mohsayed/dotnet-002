using System;

namespace ConsoleApp1;

public class DatesRepository
{
	private readonly DateOnly[] _holidayDates = [
		new(2026, 12, 25), // Christmas Day
		new(2026, 12, 26), // Boxing Day 
		new(2027, 1, 1),   // New Year's Day
		new(2027, 3, 26),  // Good Friday
		new(2027, 3, 29),  // Easter Monday
		new(2027, 5, 3),   // Early May bank holiday
		new(2027, 5, 31),  // Spring bank holiday
		new(2027, 8, 30),  // Summer bank holiday
		new(2027, 12, 25), // Christmas Day
		new(2027, 12, 26) // Boxing Day 
    ];
	public DateOnly[] HolidayDates => _holidayDates;

	private static readonly DatesRepository _instance = new();
	public static DatesRepository Instance => _instance;

	private DatesRepository() { }
}

