




local ScreenGui = Instance.new("ScreenGui")
local ImageLabel = Instance.new("ImageLabel")


ScreenGui.Parent = game.Players.LocalPlayer:WaitForChild("PlayerGui")
ScreenGui.ZIndexBehavior = Enum.ZIndexBehavior.Sibling

ImageLabel.Parent = ScreenGui
ImageLabel.BackgroundColor3 = Color3.new(1, 1, 1)
ImageLabel.BackgroundTransparency = 1
ImageLabel.BorderColor3 = Color3.new(0, 0, 0)
ImageLabel.BorderSizePixel = 0
ImageLabel.Position = UDim2.new(0.460309356, 0, 0.440100878, 0)
ImageLabel.Size = UDim2.new(0, 97, 0, 95)
ImageLabel.Image = "rbxassetid://71517238812098"



local function HPPTCG_fake_script()
	local script = Instance.new('LocalScript', ImageLabel)

	local TweenService = game:GetService("TweenService")
	
	local imageLabel = script.Parent
	
	
	imageLabel.AnchorPoint = Vector2.new(0, 1)
	
	
	imageLabel.Position = UDim2.new(0, 571, 1, -349)
	imageLabel.Rotation = 0
	
	
	local targetPosition = UDim2.new(0, 25, 1, -18)
	
	
	local moveTween = TweenService:Create(
		imageLabel,
		TweenInfo.new(1, Enum.EasingStyle.Quad, Enum.EasingDirection.Out),
		{Position = targetPosition}
	)
	task.wait(1)
	moveTween:Play()
	moveTween.Completed:Wait()
	
	
	local angle = 10
	local tweenInfo = TweenInfo.new(
		0.50,
		Enum.EasingStyle.Sine,
		Enum.EasingDirection.InOut
	)
	
	local left = {Rotation = -angle}
	local right = {Rotation = angle}
	
	while true do
		local t1 = TweenService:Create(imageLabel, tweenInfo, left)
		t1:Play()
		t1.Completed:Wait()
	
		local t2 = TweenService:Create(imageLabel, tweenInfo, right)
		t2:Play()
		t2.Completed:Wait()
	end
end
coroutine.wrap(HPPTCG_fake_script)()
