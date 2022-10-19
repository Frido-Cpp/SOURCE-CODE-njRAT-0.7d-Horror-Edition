- IMPORTANT! -

before editing or opening code/forms in the njRAT 0.7d Horror Edition - SRC, compile in release mode!
you will run into unfixable errors if you do not do that first!

- IMPORTANT! -

if you edit form1 or maybe some the forms  and try to compile you may run to errors like:
Type 'NJRAT.L1' is not defined
Type 'NJRAT.Pp1' is not defined
Type 'NJRAT.Gclass9' is not defined

this happen in compileing, to fix ther error and use normally again edit it:
--

FROM 
        Me.L1 = New NJRAT.L1()
        Me.Pp1 = New NJRAT.Pp1()

TO
        Me.L1 = New L1()
        Me.Pp1 = New Pp1()

--
Remove the "NJRAT." and the erorr will go away and not break the rat
if you do it wrong the notf form will never show up (no notification working)
--

When you build it the solutions, move the bins to  njRAT 0.7d Horror Edition - BIN
then your mod will function, it cannot work in a single exe mode.

if you builde a new plugin, move it to the   njRAT 0.7d Horror Edition - BIN
plugins folder, and replace them with your new one.

- TheGhost -

IF YOU RUN INTO ERROR Please Open an Issue in github. i can try to fix or show
how to add new feature or more.
github.com/de-eloper