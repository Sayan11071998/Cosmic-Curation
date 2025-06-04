# 🚀 Cosmic Curation – A Space Battle Adventure! 🌌

**Cosmic Curation** is a fast-paced arcade-style space shooter built in **Unity**. Take control of a nimble spaceship, dodge enemy fire, collect power-ups, and battle through waves of relentless enemies. Designed with performance, scalability, and clean architecture in mind, this project delivers both excitement and technical depth.

---

## 🎮 Game Features

### ✨ Dynamic Movement
- Smooth 360° spaceship movement and rotation using Unity's Rigidbody2D physics.

### 🔫 Intense Combat Mechanics
- Fire projectiles to destroy enemy ships.
- Enemies shoot, follow, and crash into the player dynamically.

### ⚡ Power-Ups System (Scriptable Objects)
- **Double Turret**: Fire two bullets at once.
- **Rapid Fire**: Temporarily boost firing rate.
- **Shield**: Gain temporary invincibility from enemy attacks.
- Power-ups are timed and collectible in-game.

### 👾 Enemy AI
- Enemies adapt their movement and behavior when within range.
- Spawn waves for escalating challenge.

### 🎆 Visual & Audio Effects
- Explosive VFX and engaging SFX enhance combat feel.
- Implemented dynamic explosions, muzzle flashes, and shield effects.

---

## 🛠️ Architecture & Technical Highlights

### ♻️ Object Pooling Pattern
- Optimized performance by recycling:
  - Bullets
  - Enemies
  - Power-ups
  - VFX assets

### 🧩 Service Locator Pattern (GenericMonoSingleton)
- Centralized control of:
  - Audio Service
  - VFX Service
  - Game Manager
- Promotes scalable, modular system management.

### 🔉 Scriptable Audio System
- All sound effects (fire, hit, collect) handled via **ScriptableObjects** for flexibility and reuse.

---

## 💡 Key Learnings

- **Object Pooling**: Dramatically improved runtime performance.
- **Service Locator Pattern**: Centralized service architecture for clean and maintainable code.
- **Modular Gameplay Systems**: Created scalable systems using interfaces, inheritance, and generic patterns.
- **ScriptableObject Architecture**: Simplified data-driven design for power-ups and audio clips.
- **Clean UI Feedback**: Designed responsive HUD with power-up timers and visual alerts.

---

## 📁 Play Link


[![Watch the video](https://img.youtube.com/vi/okDVSExl-IE/maxresdefault.jpg)](https://youtu.be/okDVSExl-IE)
### [Gameplay Video](https://youtu.be/okDVSExl-IE)

![Image](https://github.com/user-attachments/assets/0a19d34e-5c99-4fa5-b441-8578c7e808f7)

![Image](https://github.com/user-attachments/assets/e899c656-5d3d-4891-b80a-e4680b3a16ce)

![Image](https://github.com/user-attachments/assets/914f0e3a-f28f-4cdc-97f9-620c51b54dbe)
