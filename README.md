# CountSort
 This is an algorithm I came up with in college around 15 years ago, when given the task of writing a sorting algorithm during our algorithms course. I assumed this was a rather obvious approach, but I haven't really seen anyone else use this approach yet. So in case it's useful to anyone, I thought I'd finally go ahead and publish it. 
 
 It's significantly faster than the built-in Array.Sort() in .NET 7.0 in certain cases. Of course, in some cases it's significantly slower. If you care a _LOT_ about the performance of your sorting algorithm you know a context-aware approach is needed (as is shown in the uint example). So here is another tool in the toolbelt :)

 C# is the language I'm working the most in at the moment, so that's what I chose to implement this in for the time being. Sorry, or you're welcome.

 Be sure to check out the included benchmarks, as this algorithm is only useful in a few very special cases.