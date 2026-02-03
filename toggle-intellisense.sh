#!/bin/bash

# Toggle IntelliSense between practice mode (disabled) and review mode (enabled)
# Usage: ./toggle-intellisense.sh

SETTINGS_FILE=".vscode/settings.json"
REVIEW_FILE=".vscode/settings.review.json"
TEMP_FILE=".vscode/settings.temp.json"

if [ ! -f "$SETTINGS_FILE" ] || [ ! -f "$REVIEW_FILE" ]; then
    echo "Error: Settings files not found!"
    exit 1
fi

# Check if currently in practice mode (disabled) by looking for "other": false
if grep -q '"other": false' "$SETTINGS_FILE"; then
    echo "Switching to REVIEW mode (IntelliSense ENABLED)..."
    # Swap: practice -> review
    mv "$SETTINGS_FILE" "$TEMP_FILE"
    mv "$REVIEW_FILE" "$SETTINGS_FILE"
    mv "$TEMP_FILE" "$REVIEW_FILE"
    echo "✓ IntelliSense is now ENABLED (Review mode)"
else
    echo "Switching to PRACTICE mode (IntelliSense DISABLED)..."
    # Swap: review -> practice
    mv "$SETTINGS_FILE" "$TEMP_FILE"
    mv "$REVIEW_FILE" "$SETTINGS_FILE"
    mv "$TEMP_FILE" "$REVIEW_FILE"
    echo "✓ IntelliSense is now DISABLED (Practice mode)"
fi

echo ""
echo "Note: You may need to reload Cursor for changes to take effect."
echo "Press Cmd+Shift+P (Mac) or Ctrl+Shift+P (Windows/Linux) and type 'Reload Window'"
