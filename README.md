# Holo Tag Recognition
An example on how you can identify specific tags in your environment with HoloLens. The code is based on the blog post: http://www.andrei-ermilov.net/virtual-reality/identifying-tags-in-3d-space-with-hololens/.

Please note it does not work in emulator, you will need a HoloLens device to deploy this solution. This is because Vuforia have not released a version 

# Getting started
- You will need to have the HoloLens tools installed: https://developer.microsoft.com/en-us/windows/holographic/install_the_tools
- Complete the Getting started with Vuforia section of the blog post to get your App Key (step 2) and Target Database package (step 5)
- Import your database package into the Unity Solution
- Open the ARCamera gameobject, add your app key and activate the database under Database Load Behaviour
- Deploy to a device and look at your tag! 
