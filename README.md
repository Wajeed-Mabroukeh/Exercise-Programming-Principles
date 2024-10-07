# Exercise Programming Principles
<b>Project Overview</b><br>
This project is a console-based application developed in C# for FTS company as part of backend developer training.
This C# console application simulates a real-time weather monitoring and reporting service. The system receives weather data in different formats (JSON, XML) from various weather stations, and depending on the data, it triggers specific weather bots that behave according to pre-defined rules. The bots are activated based on conditions such as temperature and humidity, making this project an excellent demonstration of design patterns and SOLID principles, particularly focusing on extensibility and modularity

## Features
- **Multi-format Input Support**: Process weather data in both JSON and XML formats.
- **Configurable Bots**: Different types of weather bots that get activated based on the data they receive (e.g., RainBot, SunBot, SnowBot).
- **Design Patterns**: Demonstrates the Observer and Strategy patterns, as well as adherence to SOLID principles.
- **Easy Extendibility**: New weather data formats and bot types can be added with minimal changes.

## Weather Bots
1. **RainBot**: Activated when humidity exceeds a set threshold.
2. **SunBot**: Activated when temperature exceeds a set threshold.
3. **SnowBot**: Activated when temperature drops below a set threshold.
Each bot has its own activation criteria and can print pre-configured messages.

## Configuration File
The bot configuration is managed via a JSON file. The configuration determines:

- **Thresholds**: Limits for activating each bot.
- **Messages**: What each bot will print upon activation.
- **Enabled**: Whether the bot is active or not.

## How It Works
1. **Step 1**: Start the application.
2. **Step 2**: Enter weather data in either JSON or XML format.
3. **Step 3**: The system processes the data and activates bots according to the provided data and bot configuration.
4. **Step 4**: The bot outputs a pre-configured message if activated.

## Getting Started
<b>Prerequisites</b><br>
.NET 6 or later

### Setup Instructions
1. Clone the repository:
    ```bash
    https://github.com/Wajeed-Mabroukeh/Exercise-Programming-Principles.git
    ```
2. Navigate to the project directory:
    ```bash
    cd Exercise-Programming-Principles
    ```
3. Build and run the application:
    ```bash
    dotnet build
    dotnet run
    ```
4. Modify the config.json file to adjust bot settings if necessary.

## Future Enhancements
- Add support for new data formats (e.g., CSV, YAML).
- Implement additional bot types (e.g., WindBot, StormBot).
- Add a graphical user interface (GUI) for easier interaction.

