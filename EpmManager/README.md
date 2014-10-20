----------------
WHY EPM MANAGER?
---------------- 


When Microsoft introduced Windows 8, one of their "new security feature" was AppContainers - new concept how to run "untrusted" applications safely. In particular, when IE runs in an Enhanced Protection Mode, it executes ActiveX controls, BHO and other IE addons in an AppContainer with limited permissions. It did increase the security level, however a lot of innocent ActiveX controls was affected. It is not so easy to adapt those software to AppContainers and it would require way too much resources, so new IE made it impossible to use them. 

That's why Microsoft made two things: they turned off EPM (Enhanced Protection Mode) by default and even if it is enabled, but the page tries to load an AppContainer incompatible ActiveX control, IE asks whether the user wants to turn off EPM for this particular website. Once the user selects an answer, IE remembers it and never asks again. However if the user selects a wrong answer (which is quite easy, especially on IE10 with a very confusing dialog), there is no chance to change his mind without tweaking an undocumented registry entries. It is too difficult and uncomfortable for a regular user. 

That's why I created this small utility - EPM Manager. It checks this registry entry (HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\TabProcConfig) and allows the user to switch between different states of EPM for a particular website. 



------------------
ADDITIONAL READING
------------------


General info about EPM:

http://blogs.msdn.com/b/ieinternals/archive/2012/03/23/understanding-ie10-enhanced-protected-mode-network-security-addons-cookies-metro-desktop.aspx

Where I have found out how IE stores information about EPM mode for each site: 

http://blogs.msdn.com/b/ie/archive/2012/11/13/ie10-fast-fluid-perfect-for-touch-and-available-now-for-windows-7.aspx#10369000


-------
LICENSE
-------

The MIT License (MIT)
Copyright (c) 2014 Andrew Simontsev (Aurigma, Inc.)

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions: The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.


-------------------
THIRD-PARTY CONTENT
-------------------


Application icons (buttons, listview) were generated on icomoon.io (free set). 

The application icon was taken on www.iconfinder.com (https://www.iconfinder.com/icons/12599/download/ico)