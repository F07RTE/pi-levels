# Local Teams Development Setup

1. Download and install ngrok from https://ngrok.com/download

2. Start your Blazor app:
   ```
   cd PiLevels
   dotnet run
   ```

3. In a new terminal, start ngrok:
   ```
   ngrok http https://localhost:7167
   ```

4. Copy the ngrok HTTPS URL (e.g., https://xxxx.ngrok.io)

5. Update the manifest.json with your ngrok URL

6. Create a zip package with:
   - manifest.json
   - color.png
   - outline.png

7. Upload the package to Teams:
   - Go to Teams
   - Click Apps > Manage your apps > Upload an app
   - Choose "Upload a custom app"
   - Select your zip package

Note: The ngrok URL changes each time you restart ngrok. You'll need to update the manifest.json and repackage when this happens.
