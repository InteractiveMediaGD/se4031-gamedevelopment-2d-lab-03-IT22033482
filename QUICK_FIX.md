# Quick Fix Guide - Projectile Tag & Visibility Issues

## Problem 1: "Tag: Projectile is not defined" Error

**Fix this FIRST:**

1. In Unity, go to **Edit → Project Settings**
2. Click on **Tags and Layers** (in the left sidebar)
3. Under **Tags** section, expand the list
4. Click the **+** button to add a new tag
5. Name it exactly: **Projectile** (capital P, rest lowercase)
6. Click **Save** or press Enter

7. Now select your **Projectile prefab** in the Project window (should be in Prefabs folder)
8. At the top of the Inspector, find the **Tag** dropdown (next to Layer)
9. Select **Projectile** from the dropdown

**This will fix the tag error!**

---

## Problem 2: Projectiles Not Visible

**Make projectiles bigger and brighter:**

1. Select your **Projectile prefab** in the Project window
2. In Inspector, check these settings:

   **Transform:**
   - Scale: Make sure it's at least **(0.5, 0.5, 1)** or bigger (try **1, 1, 1** for testing)

   **Sprite Renderer:**
   - Color: Make it bright **Yellow** (R: 255, G: 255, B: 0, A: 255)
   - Sorting Layer: Default
   - Order in Layer: Make sure it's **higher than player** (e.g., 1 or 2)

3. If still not visible, try:
   - Make the projectile scale even bigger: **(2, 2, 1)**
   - Change color to bright **Red** or **White** temporarily to test

---

## Problem 3: Score Decreasing When Player Hits Enemy

**This should be fixed now** - the Enemy script only increases score when hit by projectiles, not when hitting the player.

**To verify:**
- When player touches enemy → Only health decreases, score stays same
- When projectile hits enemy → Score increases by 5, enemy destroyed

---

## Testing Checklist

After fixing the tag:

1. ✅ Press **Play**
2. ✅ Click **Left Mouse Button** → Should see yellow projectile spawn
3. ✅ Projectile should move to the right
4. ✅ When projectile hits enemy → Enemy destroyed, score increases by 5
5. ✅ When player touches enemy → Only health decreases, score unchanged

---

## If Projectiles Still Don't Appear:

1. Check **Player** has **PlayerShoot** component
2. Check **Projectile Prefab** field is assigned in PlayerShoot component
3. Check projectile prefab exists in Project window
4. Try making projectile scale **(3, 3, 1)** temporarily to see if it's just too small
5. Check Console for any other errors

---

## Quick Tag Creation Alternative:

If the above doesn't work, try this:

1. Select ANY GameObject in Hierarchy
2. Look at Inspector → Tag dropdown (top)
3. Click **Add Tag...**
4. Click **+** button
5. Name: **Projectile**
6. Click **Save**
7. Now select Projectile prefab and assign the tag

