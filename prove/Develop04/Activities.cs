using System;
using System.Threading;

namespace Develop04
{
    public abstract class Activities
    {
        protected internal int duration;
        protected CancellationTokenSource cancellationTokenSource;

        public void LoadSpinner(int duration = 5)
        {
            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(duration);

            DateTime currentTime = DateTime.Now;

            while (currentTime < futureTime)
            {
                Console.Write("|"); // Add |

                currentTime = DateTime.Now;

                Thread.Sleep(400);

                Console.Write("|"); // Add |

                currentTime = DateTime.Now;

                Thread.Sleep(400);

                Console.Write("|"); // Add |

                currentTime = DateTime.Now;

                Thread.Sleep(400);

                Console.Write("\b \b"); // Remove |
                Console.Write("\b \b"); // Remove |
                Console.Write("\b \b"); // Remove |

                currentTime = DateTime.Now;

                Thread.Sleep(400);
            }

        }

        public abstract void StartActivity();

        protected abstract void StartMessage(int duration);
        protected abstract void EndMessage(int duration);

        protected void LogData(string activityName, int duration)
        {
            // Log the activity data
            Console.WriteLine();
            Console.WriteLine("--- Activity Log ---");
            Console.WriteLine("Activity: " + activityName);
            Console.WriteLine("Duration: " + duration + " seconds");
            Console.WriteLine("--------------------");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
