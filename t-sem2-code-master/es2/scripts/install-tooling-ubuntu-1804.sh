#!/bin/bash
#-------------------------------------------------------------
#
# Script for installing environment on Linux systems
#
#-------------------------------------------------------------
function reportStep {
	local message="$@"
        local line="---------------------------------------------------------------------"
	echo $line
	echo "" 
	echo $message
	echo "" 
}

#Stop script when any of the command fails:
set -e

reportStep "Adding repositories to apt:"
wget -q https://packagecloud.io/AtomEditor/atom/gpgkey -O- | sudo apt-key add -
sudo apt-get install -y atom

reportStep "Installing additional software:"
sudo apt update
sudo apt-get install -y atom clang build-essential make gcc g++ npm nodejs llvm libclang-dev git ssh dos2unix geany tree

reportStep "Installing Platform IO packages:"
apm install autocomplete-clang busy-signal linter linter-gcc build build-make linter-ui-default intentions

reportStep "Adding user to dialout group for Arduino serial communication:"
sudo adduser student dialout

reportStep "Adding Arduino to udev rules:"
wget https://raw.githubusercontent.com/platformio/platformio/develop/scripts/99-platformio-udev.rules
sudo cp 99-platformio-udev.rules /etc/udev/rules.d/.
rm 99-platformio-udev.rules

reportStep "Installation done... enjoy!"

# Manual steps:
reportStep "Please set manually (to prevent include wrong include warnings)"
reportStep "Update Atom settings of package' Linter-gcc'"
reportStep "       -> Settings --> 'GCC Include Paths' should be '/*'"
