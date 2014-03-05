EmbeddedStaticIssue
===================

A repro repo for issues with my fork of Nancy.Embedded.

![i-feel-like-im-taking-crazy-pills](https://f.cloud.github.com/assets/238079/2337099/48208558-a499-11e3-83cc-d207e1145506.gif)

To test this
------------

1. Clone this project
2. Build the solution (i think NuGet should restore stuff correctly for you)
3. Select the Demo.FileSystem project and run it
4. Browse to http://localhost:8080 and open devtools -> network
5. Click on the link a bunch of times and watch the image only get loaded once

Then try the other project:

1. Select the Demo.Embedded project
2. Run it
3. Browse to http://localhost:4444 and open devtools -> network
4. Click on the link a bunch of times and watch the image only get loaded once

When i do this i see [this diff between the headers in Fiddler gist](https://gist.github.com/jugglingnutcase/b35c3ee15b650bb5291b).

i'm using Chrome Version 33.0.1750.146 m on Windows. Maybe this doesn't happen in other browsers? The whole reason i'm doing this is because i'm seeing this crop up in a real-world application on iOS Mobile Safari as well and it's messing up images used in real-time updates i have going in SignalR.


Questions
---------

i have many questions

1. How can i improve in my devtools skills to figure out what is actually happening?
2. What causes a the browser to download an image tag inserted via javascript?
3. What is happening and how can i fix this?
