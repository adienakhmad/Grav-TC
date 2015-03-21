==================================================================
----	About Grav-TC Version 1.1.3
==================================================================

This is a program to generate correction table for measured gravity data.
Value calculated is the UPWARD pull due to the sun and moon.
To use as correction to measured gravity data, you would need to ADD these numbers, not subtract them.

The algorithm used is that of Longman, I.M., Formulas for Computing the Tidal Acceleration Due to the Moon and the Sun., J. Geoph. Res., 1959

Math calculation are ported from TIDES program by J. L. Ahern which was written in QBASIC.

Copyright © 2014-2015 Adien Akhmad
Department of Geophysics, Universitas Gadjah Mada

==================================================================
----	How to use
==================================================================

There are two modes you can use this program.

1. Compute variations in g due to the moon and sun as a function of time on a given location on earth. (Normal mode)
2. Compute g due to the moon and sun as a function of location and time. (Read from file mode)

==================================================================
----	Normal Mode
==================================================================
You can find all the controls in the main windows.
	These are the paramaters you must set:
	1. Position
		X-Position	: Longitude or Easting (to switch between geographic and projected system click [Coordinate Sytem] menu and select from there)
		Y-Position	: Latitude or Northing (to switch between geographic and projected system click [Coordinate Sytem] menu and select from there)
		Elevation	: in meters
	2. Time
		Time Zone	: the time zone of the begin time and end time.
		Begin Time	: the program will start the calculation at this specified hour, day, month and year. Value must be earlier than End Time.
		End Time	: the program will stop the calculation at this specified hour, day, month and year. Value must be later than Begin Time.
		Interval	: the time interval the program will be using, value are in minutes.
	
	These are displayed after calculation:
	1. Table
		Date Time	: value of the time used in calculation.
		g Moon		: calculated variation of g due to the moon
		g Sun		: calculated variation of g due to the sun
		g Total		: combined variation of g due to the moon and sun (g0)
	2. Chart		: display a line chart representing variations of g0 versus time.
	
==================================================================
----	Read From File Mode
==================================================================

You can find the controls by clicking [File] and [Read From File]. A pop up window will appear.

	1. Click on [Open] to select your file.
	2. Set the time zone to match the time zone of the time in your text file.
	3. Change coordinate system to match the coordinates in your text file.
	4. If UTM coordinate system is selected, a combo box control will be active, click on the arrow and select the UTM zone of the coordinates in your text file.
	5. Click [Generate]
	6. A new column containing the calculated g will appear.
	7. Click [Copy] if you wish to copy the generated table to clipboard.
	8. Click [Save As] if you wish to save the generated table to a text file.
	
==================================================================
----	File Input Format (a sample file is provided)
==================================================================

	The file extension can be in any format (as long as it is a text file).
	Any line beginning with '#' are treated as comment and will be ignored.
	
	The input text format must be on the following structure (must be tab delimited) :
	
		datetime    x-position    y-position    elevation

	Supported datetime format :
		d-M-yy H:mm 		16-3-15 14:00
		d-M-yyyy H:mm 		16-3-2015 14:00
		d-M-yyyy H:mm:ss	16-3-2015 14:00:00
		
	X-Position and Y-Position can be in either geographic decimal degree or UTM, elevation are in meters.

		110.1116	-7.89996	100
		or
		402071.53	9126653.36	100

	Above combined we have the complete format

		# grav-tc file input format geographic coordinate example
		16-03-2015 14:00    110.1116    -7.89996    100
		16-03-2015 14:03    110.1234    -7.89996    130
		16-03-2015 14:07    110.1356    -7.89996    98

		or

		# grav-tc file input format UTM coordinate example
		17-03-2015 14:00    402071.53    9126653.36    100
		17-03-2015 14:03    403071.53    9126653.36    130
		17-03-2015 14:07    404071.53    9126653.36    98
		
==================================================================
----	Credits
==================================================================

		J. L. Ahern, the original author of TIDES.
		Tom Van Baak, for conversion of TIDES from QBASIC to C.
		Yusuke Kamiyamane, for the awesome icons.
		ZedGraph library, for the line chart.
		ProjNet library, for the conversion of coordinates system.
		FileHelpers library, for file handling.
		
==================================================================
----	Change Log
==================================================================
# v1.0b
	- First Beta Release
# v1.0b2
	- Bug Fixed	: Incorrectly convert deg min sec to decimal
	- Changed	: Coordinate now only accept positive number.
	- Added		: Option to choose N/S and E/W
# v1.0
	- New		: Tab Control and Chart
	- Fixed		: Application now show wait cursor on loading.
# v1.1.0 (15 March 2015)
	- Code restructure.
	- GUI Improvement
	- New		: added support for coordinate input in Projected Coordinate System (WGS84 UTM)
	- New		: Coordinate System menu to switch between different coordinate system and format.
	- New		: read from file mode
	- Changed	: Edit menu is removed. Replaced by Coordinate System menu.
# v1.1.3 (21 March 2015)
	- Fixed		: Wrong latitude and longitude limit on Deg Min Sec mode after switching from other input mode.
	- Changed	: When latitude value are 90, minute and seconds value will automatically reset to zero.
				  When longitude value are 180, minute and seconds value will automatically reset to zero.
				
				