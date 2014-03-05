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
2. Browse to http://localhost:4444 and open devtools -> network
3. Click on the link a bunch of times and watch the image only get loaded once

i'm using Chrome Version 33.0.1750.146 m on Windows. Maybe this doesn't happen in other browsers? The whole reason i'm doing this is because i'm seeing this crop up in a real-world application on iOS Mobile Safari as well and it's messing up images used in real-time updates i have going in SignalR.

When i do this i see ([here's a gist](https://gist.github.com/jugglingnutcase/b35c3ee15b650bb5291b) if you want that instead of the following):

```diff
--- .\filesystem-headers.txt	Wed Mar  5 12:14:16 2014
+++ .\embedded-headers.txt	Wed Mar  5 12:09:55 2014
@@ -1,5 +1,5 @@
-GET http://localhost:8080/ HTTP/1.1
-Host: localhost:8080
+GET http://localhost:4444/ HTTP/1.1
+Host: localhost:4444
 Connection: keep-alive
 Cache-Control: max-age=0
 Accept: text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8
@@ -14,20 +14,20 @@
 Content-Type: text/html
 Vary: Accept
 Server: Microsoft-HTTPAPI/2.0
-Date: Wed, 05 Mar 2014 17:13:18 GMT
+Date: Wed, 05 Mar 2014 17:09:28 GMT
 
 
 
 ------------------------------------------------------------------
 
-GET http://localhost:8080/Content/jquery.min.js HTTP/1.1
-Host: localhost:8080
+GET http://localhost:4444/Content/jquery.min.js HTTP/1.1
+Host: localhost:4444
 Connection: keep-alive
 Cache-Control: max-age=0
 Accept: */*
 User-Agent: Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/33.0.1750.117 Safari/537.36
 DNT: 1
-Referer: http://localhost:8080/
+Referer: http://localhost:4444/
 Accept-Encoding: gzip,deflate,sdch
 Accept-Language: en-US,en;q=0.8
 
@@ -35,23 +35,23 @@
 HTTP/1.1 200 OK
 Transfer-Encoding: chunked
 Content-Type: application/x-javascript
-Last-Modified: Fri, 07 Feb 2014 14:57:43 GMT
-ETag: "8d0f22c16929d2e"
+Last-Modified: Wed, 05 Mar 2014 17:09:20 GMT
+ETag: "88346F90AB22CAADE9507086AC9C1026"
 Server: Microsoft-HTTPAPI/2.0
-Date: Wed, 05 Mar 2014 17:13:18 GMT
+Date: Wed, 05 Mar 2014 17:09:28 GMT
 
 
 
 ------------------------------------------------------------------
 
-GET http://localhost:8080/Content/hogan.min.js HTTP/1.1
-Host: localhost:8080
+GET http://localhost:4444/Content/app.js HTTP/1.1
+Host: localhost:4444
 Connection: keep-alive
 Cache-Control: max-age=0
 Accept: */*
 User-Agent: Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/33.0.1750.117 Safari/537.36
 DNT: 1
-Referer: http://localhost:8080/
+Referer: http://localhost:4444/
 Accept-Encoding: gzip,deflate,sdch
 Accept-Language: en-US,en;q=0.8
 
@@ -59,23 +59,23 @@
 HTTP/1.1 200 OK
 Transfer-Encoding: chunked
 Content-Type: application/x-javascript
-Last-Modified: Fri, 07 Feb 2014 14:57:42 GMT
-ETag: "8d0f22c168110bc"
+Last-Modified: Wed, 05 Mar 2014 17:09:20 GMT
+ETag: "0E0C646DEBC03179147EAC98C93A95DD"
 Server: Microsoft-HTTPAPI/2.0
-Date: Wed, 05 Mar 2014 17:13:18 GMT
+Date: Wed, 05 Mar 2014 17:09:28 GMT
 
 
 
 ------------------------------------------------------------------
 
-GET http://localhost:8080/Content/app.js HTTP/1.1
-Host: localhost:8080
+GET http://localhost:4444/Content/hogan.min.js HTTP/1.1
+Host: localhost:4444
 Connection: keep-alive
 Cache-Control: max-age=0
 Accept: */*
 User-Agent: Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/33.0.1750.117 Safari/537.36
 DNT: 1
-Referer: http://localhost:8080/
+Referer: http://localhost:4444/
 Accept-Encoding: gzip,deflate,sdch
 Accept-Language: en-US,en;q=0.8
 
@@ -83,17 +83,17 @@
 HTTP/1.1 200 OK
 Transfer-Encoding: chunked
 Content-Type: application/x-javascript
-Last-Modified: Wed, 05 Mar 2014 16:49:01 GMT
-ETag: "8d106a9f22960f9"
+Last-Modified: Wed, 05 Mar 2014 17:09:20 GMT
+ETag: "66D02635CEB1198F4B9E2C9303B6DEB0"
 Server: Microsoft-HTTPAPI/2.0
-Date: Wed, 05 Mar 2014 17:13:18 GMT
+Date: Wed, 05 Mar 2014 17:09:28 GMT
 
 
 
 ------------------------------------------------------------------
 
-GET http://localhost:8080/favicon.ico HTTP/1.1
-Host: localhost:8080
+GET http://localhost:4444/favicon.ico HTTP/1.1
+Host: localhost:4444
 Connection: keep-alive
 Accept: */*
 DNT: 1
@@ -107,19 +107,19 @@
 Transfer-Encoding: chunked
 Content-Type: image/vnd.microsoft.icon
 Server: Microsoft-HTTPAPI/2.0
-Date: Wed, 05 Mar 2014 17:13:18 GMT
+Date: Wed, 05 Mar 2014 17:09:28 GMT
 
 
 
 ------------------------------------------------------------------
 
-GET http://localhost:8080/Content/face.png HTTP/1.1
-Host: localhost:8080
+GET http://localhost:4444/Content/face.png HTTP/1.1
+Host: localhost:4444
 Connection: keep-alive
 Accept: image/webp,*/*;q=0.8
 User-Agent: Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/33.0.1750.117 Safari/537.36
 DNT: 1
-Referer: http://localhost:8080/
+Referer: http://localhost:4444/
 Accept-Encoding: gzip,deflate,sdch
 Accept-Language: en-US,en;q=0.8
 
@@ -127,10 +127,76 @@
 HTTP/1.1 200 OK
 Transfer-Encoding: chunked
 Content-Type: image/png
-Last-Modified: Tue, 04 Mar 2014 13:50:06 GMT
-ETag: "8d105c7c8dbcf21"
+Last-Modified: Wed, 05 Mar 2014 17:09:31 GMT
+ETag: "817568740254D9477638481BE0455AD1"
 Server: Microsoft-HTTPAPI/2.0
-Date: Wed, 05 Mar 2014 17:13:48 GMT
+Date: Wed, 05 Mar 2014 17:09:31 GMT
+
+
+
+------------------------------------------------------------------
+
+GET http://localhost:4444/Content/face.png HTTP/1.1
+Host: localhost:4444
+Connection: keep-alive
+Accept: image/webp,*/*;q=0.8
+If-None-Match: "817568740254D9477638481BE0455AD1"
+If-Modified-Since: Wed, 05 Mar 2014 17:09:31 GMT
+User-Agent: Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/33.0.1750.117 Safari/537.36
+DNT: 1
+Referer: http://localhost:4444/
+Accept-Encoding: gzip,deflate,sdch
+Accept-Language: en-US,en;q=0.8
+
+
+HTTP/1.1 304 Not Modified
+Content-Length: 0
+Server: Microsoft-HTTPAPI/2.0
+Date: Wed, 05 Mar 2014 17:09:32 GMT
+
+
+
+------------------------------------------------------------------
+
+GET http://localhost:4444/Content/face.png HTTP/1.1
+Host: localhost:4444
+Connection: keep-alive
+Accept: image/webp,*/*;q=0.8
+If-None-Match: "817568740254D9477638481BE0455AD1"
+If-Modified-Since: Wed, 05 Mar 2014 17:09:31 GMT
+User-Agent: Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/33.0.1750.117 Safari/537.36
+DNT: 1
+Referer: http://localhost:4444/
+Accept-Encoding: gzip,deflate,sdch
+Accept-Language: en-US,en;q=0.8
+
+
+HTTP/1.1 304 Not Modified
+Content-Length: 0
+Server: Microsoft-HTTPAPI/2.0
+Date: Wed, 05 Mar 2014 17:09:34 GMT
+
+
+
+------------------------------------------------------------------
+
+GET http://localhost:4444/Content/face.png HTTP/1.1
+Host: localhost:4444
+Connection: keep-alive
+Accept: image/webp,*/*;q=0.8
+If-None-Match: "817568740254D9477638481BE0455AD1"
+If-Modified-Since: Wed, 05 Mar 2014 17:09:31 GMT
+User-Agent: Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/33.0.1750.117 Safari/537.36
+DNT: 1
+Referer: http://localhost:4444/
+Accept-Encoding: gzip,deflate,sdch
+Accept-Language: en-US,en;q=0.8
+
+
+HTTP/1.1 304 Not Modified
+Content-Length: 0
+Server: Microsoft-HTTPAPI/2.0
+Date: Wed, 05 Mar 2014 17:09:35 GMT
```

