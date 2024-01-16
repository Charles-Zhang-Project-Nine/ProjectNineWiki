This is a test file.

This file tests two things: 
1) How do we represent the "folder page" by using a specially named markdown file
2) How do we allow linking media files specifically for wiki (we might need better preview capabilities)

<video width="500" height="281" controls="" autoplay><source type="video/mp4" src="../_Media/test.mp4"></source></video>

Comment:

Currently VS Code's *markdown preview* and *live server (for html)* cannot do this - we might need a very simple custom ASP.Net Core server for dealing with this (and we can easily add custom extensions there, e.g. auto-referencing of children pages, and auto-generation of navigation structure).