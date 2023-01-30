var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
 
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler();
    app.UseHsts();
}
 
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.UseEndpoints(endpoints =>endpoints.MapDefaultControllerRoute());

app.Run();
