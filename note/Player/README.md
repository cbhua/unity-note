# Player

1. 创建角色图层：Hierarchy → Create 2D Object → Sprite

2. 导入角色素材：Player Sprite → Inspector → Sprite Renderer → Sprite → Drag Image in

3. 增加物理刚体：Player Sprite → Component → Rigidbody 2D

4. 增加物理碰撞：Player Sprite → Component → Box Collider 2D (Or other better Colliders) → Adjust Collider Bounds

   修正 Bug：持续碰撞会粘贴在竖向平台上的问题。

   添加材质：

   1. 创建材质文件：Folder → Create Physic Material 2D
   2. 设置参数：Material Inspector → Friction → 0 （无摩擦力）
   3. 给 Player 添加这个材质：Player Inspector → Collision Material → Add the Physic Material

5. 设置角色移动：

   1. 设置游戏输入：Unity Edit → Project Setting → Input Manager

      所有的游戏输入可以在这里设置，在代码中直接读取输入种类的名字就可以了。

   2. 创建 Script：Player Inspector → Component → Add New Script → Save to Folder

   3. 撰写 Script：参考角色移动 Script

6. 锁定 Z 轴旋转：Rigidbody2D → Constrains → Lock Z

   Tips: Inspector 中修改数值在游戏停止运行之后不会保存，可以通过 Inspector 中的 Copy Value 然后停止游戏运行之后 Paste Value 实现

7. 识别面朝方向：参考角色移动 Script