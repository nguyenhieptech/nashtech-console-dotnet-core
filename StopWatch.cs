using System;

namespace ConsoleApp
{
  class StopWatch
  {
    DateTime _StartDate;
    DateTime _EndDate;

    public StopWatch()
    {
      _StartDate = DateTime.Now;
    }

    public StopWatch(DateTime startDate, DateTime endDate)
    {

    }
  }
}