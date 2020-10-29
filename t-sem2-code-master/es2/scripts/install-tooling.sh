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
sudo add-apt-repository --yes ppa:webupd8team/atom
curl -sL https://deb.nodesource.com/setup_8.x | sudo -E bash -
#sudo add-apt-repository --yes ppa:chris-lea/node.js

reportStep "Installing additional software:"
sudo apt update
sudo apt-get install -y open-vm-tools open-vm-tools-desktop open-vm-tools-dkms atom clang build-essential make gcc g++ npm nodejs llvm libclang-dev git ssh dos2unix geany tree

reportStep "Installing Platform IO packages:"
apm install platformio-ide autocomplete-clang busy-signal linter linter-gcc build build-make linter-ui-default intentions

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

