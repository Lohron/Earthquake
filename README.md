# Earthquake — Evacuation Level Design

**A first-person environmental navigation level built in Unreal Engine 5.6.**

Earthquake explores how a player can find their way through a disaster-affected environment using level composition and environmental guidance rather than explicit directional signage.

![Composed scene 1](Product/New/Composed%20Scenes/Composed%20Scene1.png)

## At a glance

| | |
|---|---|
| **Project type** | Level design / walking simulator |
| **Engine** | Unreal Engine 5.6 |
| **Focus** | Player navigation, environmental storytelling, visual guidance |
| **Project file** | `Earthquake.uproject` |

## Design goals

- Create a clear evacuation journey through changing interior and exterior spaces.
- Use **path layout, lighting, leading lines, color, scale, motion, and sound** to guide players naturally.
- Build moments of discovery and tension around a disrupted environment, including routes around fallen structures.
- Compose distinct viewpoints along the intended player path.

These describe the project's design aims, not an independent playtest or completion certification.

## Level composition

The repository contains an Unreal map at `Content/Earthquake.umap` and three exported composed-scene images:

| Scene 1 | Scene 2 | Scene 3 |
|---|---|---|
| ![Composed scene 1](Product/New/Composed%20Scenes/Composed%20Scene1.png) | ![Composed scene 2](Product/New/Composed%20Scenes/Composed%20Scene2.png) | ![Composed scene 3](Product/New/Composed%20Scenes/Composed%20Scene3.png) |

### Design approach

**Navigation without signs.** The level was conceived around environmental cues that pull attention toward the intended route, while preserving a believable disaster setting.

**Spatial progression.** The intended journey alternates environmental conditions and spatial scale, building from navigable spaces toward areas affected by fallen structures.

**Framed moments.** The three composed screenshots above are starting points for evaluating sightlines, framing, and player orientation.

## Open the Unreal project

1. Install **Unreal Engine 5.6**.
2. Clone or download this repository, including Git LFS objects where applicable.
3. Open `Earthquake.uproject` in Unreal Editor.
4. Open `Content/Earthquake.umap` if it does not load automatically.

> **Note:** The repository currently contains Unreal-generated files and packaged build outputs committed before the Git ignore rules were corrected. These are not required for source-level version control. The project has not been independently built or tested as part of this portfolio documentation update.

## My work and collaboration

This repository is presented as a **level-design portfolio project**. The overview describes design objectives; detailed attribution of original meshes, textures, sounds, and any collaborators still needs to be added. Since this repository is public, verify that included materials may be redistributed. Do not assume that all assets inside the repository are original or redistributable.

## Demo and project status

- **Gameplay video:** Not yet provided
- **Playable browser demo:** Not available (Unreal Engine does not provide a standard one-click HTML5 export)
- **Packaged Windows build:** Existing build-output folders appear in the repository, but they have not been tested here

For a recruiter-facing portfolio, the next step is to add a short walkthrough video and a concise explanation of design iterations, playtesting, and individual responsibilities.

---

*This repository is public. Asset licensing, attribution, gameplay verification, and a demo still require review.*
