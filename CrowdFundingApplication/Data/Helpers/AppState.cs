﻿@page "/login"
@inject UsersService userService
<PageTitle>Counter</PageTitle>

<h3>Login</h3>

<p role="status">Current count: @currentCount</p>

<button class="btn btn-primary" @onclick="IncrementCount">Click me</button>

@code {
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }
}
