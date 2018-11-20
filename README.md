# ASP.NET Session Demo
I’ve put together examples and some slides explaining how ASP.NET Session works.

I’ve primarily focused on WebForms because for some reason people don’t tend to misuse sessions in MVC so heavily. WebForms are old, of course, but there are still plenty of apps using them.
 
The main focus is on explaining that ASP.NET session uses locks for concurrency control. The fact that ASP.NET session is locking means that no other request from the same browser will proceed until the current is being processed if they both are using a session. If authorization is stored in the session (which is a major issue by itself), it virtually means that all requests are using a session. And that leads to sequential execution of AJAX requests, new tabs aren’t loaded until previous ones have, and if the request handler crashes without releasing the session - the whole website effectively is frozen until the session is released by timeout, which is very irritating.

What can you do instead of using the session? There are plenty of other options for different situations. There is more information in the presentation. Some examples may look strange, but I saw all them in our projects!

Where to use the session? In general, in any scenario where you need to temporarily save sensitive or medium size data between requests, that consist of a small percentage of user interaction. If you have to access data in the session from a frequently visited place, you can do it in a separate asynchronous request.
