
# 🎵 Unity + FMOD Lessons

## General Concept
Learn Game-Audio in FMOD - without having to bother about integrating/ coding those connections in Unity.
With that, aspiring Game-Audio-Designers can work directly in FMOD and learn/ teach the Middleware FMOD working in a readily build game!
See setup in this Video:
*Coming Soon*



## ⚙️ General Handling
- Open Game Build 
-  Open FMOD Session and Start Live Updates
➡️That's it!
<br> 
*Some additional notes:*
- **Loop handling:** Events with the addition "Loop" in it are actively stopped by Unity - make sure they loop inside of FMOD
- **Reload scenes**: Reload the scene via the Pause Menu (by pressing escape) when you insert a new Sound on an Event which is a loop OR when you add/ remove a spatializer on an event, so FMOD calculates those correctly.
- **Notes on events**: all events, parameters, snapshots and folders in the FMOD Project have short notes on them to explain when they are triggered  
- **Organize as you like**: Events and Snapshots can be renamed, re-colored and moved in the hierachy to match your personal preference – parameters **cannot!!!!**  

---
![enter image description here](https://unity-connect-prd.storage.googleapis.com/20190313/learn/images/ef3bf79d-def0-41d8-bd08-a842cc92c0e2_PlatformerTrails.png)
---

## 📂 Structure
- Find the **Build** for your OS in the corresponding folder *(/Builds/MAC or /WIN)*
- Find the **FMOD-Session** in the corresponding folder *(/FMOD/Platformer_Unity_EN/Platformer_Unity_EN.fspro)*
- FMOD session available in **English and German**  

---

## 🎮 In-Game Options (ESC)
- Restart Level  
- Teleport to end of Level

---

## 📚 Tags & Lesson Concept
Additionally, I added Tags to all Events, by which you can filter the Events in the search bar. Those include so called "Lesson-Tags", in which I tried to group the Events with increasing difficulty - the same system is used in all my other FMOD Learning Projects and only minimal in this one:
- **Lesson 1** – Limited the project to 5 Events for a very easy Start in FMOD

---
## 📦Other FMOD Learning Projects
- [Platformer (Easy)](https://github.com/Joshnt/Platformer_FMOD-Learn)
- John Lemon (Intermediate) - Coming Soon
- Doctor FPS (Intermediate) - Coming Soon
- 	The Explorer (Advanced)
	- [Unity and FMOD Project](https://github.com/Joshnt/3DGameKit-Sample_FMOD_Learn)
	- [Builds](https://github.com/Joshnt/3DGameKit_Build_FMOD_Learn)
	- [Screencaptures](https://github.com/Joshnt/3DGameKit_Screencaptures)

*All the Demo-Games use FMOD 2.03.09 and Unity 2022.3.51f1*

*(All those games are originally designed and distributed by Unity Technologies as Learning Ressources and can be found on their website under the [Standard Unity Asset Store EULA](https://unity.com/legal/as-terms).)*
