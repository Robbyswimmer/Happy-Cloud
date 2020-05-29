# Happy-Cloud
This is a game I made a few years ago in Unity. It was released on the App Store and had about 3000 downloads. Happy Cloud is a simple game, but provided a valuable learning experience. You play as a cloud and the objective is to avoid flying, hot-air balloons and collect coins to increase your score.

![Happy Cloud](/images/launch_1334x750.png)

## The Story Behind Happy Cloud

In 2015, I was just 15 years old and a very inexperienced software developer. At the time I wasn't even sure that computer science or software engineering was something that I was interested in, let alone something that I wanted to pursue as a career. I have, however, always liked games and because of that I was fascinated by the process of creating games and wondered if it was possible for me to create my own. After a few days of research and watching YouTube videos about game development I decided I would give it a shot. Three months later Happy Cloud was released on the App Store and I had successfully finished my first major software project. It wasn't an easy process, but it is something that I am very proud of and a large part of the reason that I am pursuing computer science today.

# Happy Cloud:

## The Process

Right from the start of the development process I found [Unity](https://unity.com/) to be the best game development engine for fledgling game developers such as myself. Additionally, Unity has a great selection of tutorials and free assets that makes it easy to develop games on your own. Given this, I spent about a month learning how to use Unity and work my way around the engine. At the time the idea behind Object Oriented Programming (OOP) was, without a question, lost on me. I found that through game development, however, the concept of OOP quickly became clear. Unity makes it very easy to associate specific scripts, values, shaders, sounds, etc. with in-game objects which is how I first really understood what OOP was and how it works. 

After about a month of tutorials and messing around in Unity, I decided that it was time to start working on my own game. Given my *very* limited knowledge of game development, I wasn't totally sure where to start. Eventually I just decided to start with character movement because I assumed it would be reasonably simple.

```c#
public class Jumping : MonoBehaviour {

	public float movement;
	
	void Update () {
	     if(Input.anyKeyDown) {
	          move();
	     }
	}

	private void move() {
	     rigidbody.velocity = new Vector3(0,0,0);
	     rigidbody.AddForce (new Vector3(0, movement * 10, 0), ForceMode.Force);
	} 
}
```
It turns out, thankfully, that this assumption was true. Unity's physics engine is so powerful that only a few lines of code can create realistic 1-dimensional movement. The code above essentially applies an upward force to the player any time that the screen is touched and Unity takes care of the rest. After figuring this part out, I had the confidence to work on the other critical elements such as the environment, scoring system, player deaths, and the UI. The most difficult piece of code for me to figure out at this time actually involved the way the ground scrolled beneath the player. Since I only wanted the player to stay in one X-position, I decided to make the ground scroll underneath the player to make it seem like the player was moving. 

```c#
while (true) {
	for (int i = 0; i < hazardCount; i++){
		Vector3 spawnPosition = new Vector3 (spawnValues.x, Random.Range (spawnValues.y / 4, spawnValues.y), spawnValues.z);
		Quaternion spawnRotation = Quaternion.identity;
		Instantiate (hazard, spawnPosition, spawnRotation);
		yield return new WaitForSeconds (spawnWait);
	}
	yield return new WaitForSeconds (waveWait);
```
}

## Conclusion
