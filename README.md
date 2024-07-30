# AudioManager-VolumeControl-Unity
 Audio Mixer Create

 Window -> Audio -> Audio Mixer
 Click on + and name it Main
 
<img width="239" alt="1" src="https://github.com/user-attachments/assets/6c740538-e37d-4c34-aeb7-39156d0d990e">

On Audio Source, pass Audioclip & in output pass Master(Audio Mixer), now at runtime scroll up down the sider of mixer and see how it slow down or fast the audio. 

<img width="336" alt="2" src="https://github.com/user-attachments/assets/3769b9ec-f83e-4cad-86ff-3546c02a7af9">

______________________________________________

In group section hit +, and make new group named Music & SFX
 
<img width="602" alt="3" src="https://github.com/user-attachments/assets/7c09175e-d801-4c04-8384-0fda54a5107a">   

Right click on volume property and click Expose volume to script of Music and SFX.     

<img width="614" alt="4" src="https://github.com/user-attachments/assets/e1b5285b-918a-4b0b-ab51-e7a96805bd84"> 

![5](https://github.com/user-attachments/assets/f9ccfd86-fe37-427c-82c8-263c02cc6690)

______________________________________________

![7](https://github.com/user-attachments/assets/b6b3937b-c4dd-46ff-9ca7-e3dc575bc13d)

onValueChanged Event of sliders(music ans sfx) we are updating audiomixer groups(Music and SFX)

