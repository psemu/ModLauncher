# PS2 Mod Launcher

This is a custom launcher capable of bypassing the SOE launcher for Planetside 2 (and other Forgelight games).  It is capable of patching game files, Lua, and many other things to modify the Planetside 2 client.  It also contains a number of exploits that will force Planetside 2 to load any file you want it to load.  Every single exploit contained in this package has been reported to SOE/DGC (many of them for over two years now)

This was released in hopes that others can create something awesome in addition to jseidelin's Network and Custom Server stuff.  Only use it for good.      



# Big Important Warning

Using this for Planetside 2 on live servers **will get you banned from the game**.  Consider it a proof of concept for many of these issues.  

The command line argument method was disabled by SOE back in 2013 when it was reported.  It's kept in the modlauncher for legacy reasons.  

There is an issue with the .pack maker if you pack more than 255 files.  This is due to the fact that I didn't account for the fact that pack chunks can only contain 255 files.  If you wish to fix it, you simply need to create a new pack chunk.  The pack will be valid, but Planetside 2 won't load any more files after 255 unless there is a second chunk to contain those files (This is a bug with Planetside).  
