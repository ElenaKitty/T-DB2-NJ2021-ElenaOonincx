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

reportStep "Adding Netkit"

cd $HOME
wget https://github.com/netkit-ng/netkit-ng-core/releases/download/3.0.4/netkit-ng-core-32-3.0.4.tar.bz2
wget https://github.com/netkit-ng/netkit-ng-build/releases/download/0.1.3/netkit-ng-filesystem-i386-F7.0-0.1.3.tar.bz2
wget https://github.com/netkit-ng/netkit-ng-build/releases/download/0.1.3/netkit-ng-kernel-i386-K3.2-0.1.3.tar.bz2
tar -xjSf netkit-ng-core-32-3.0.4.tar.bz2
tar -xjSf netkit-ng-filesystem-i386-F7.0-0.1.3.tar.bz2
tar -xjSf netkit-ng-kernel-i386-K3.2-0.1.3.tar.bz2
sudo apt-get install xterm
sudo DEBIAN_FRONTEND=noninteractive apt-get -y install libc6:i386
sudo DEBIAN_FRONTEND=noninteractive apt-get -y install libgtk2.0-0:i386
sudo DEBIAN_FRONTEND=noninteractive apt-get -y install wireshark
sudo apt-get install net-tools
rm $HOME/netkit-ng-core-32-3.0.4.tar.bz2
rm $HOME/netkit-ng-filesystem-i386-F7.0-0.1.3.tar.bz2
rm $HOME/netkit-ng-kernel-i386-K3.2-0.1.3.tar.bz2

# Add netkit environment variables

BASHRC=~/.bashrc

printf "\n" >> $BASHRC
printf "export NETKIT_HOME=$HOME/netkit-ng\n" >> $BASHRC
printf "export PATH=$HOME/netkit-ng/bin:$PATH\n" >> $BASHRC
printf "export MANPATH=$MANPATH:$HOME/netkit-ng/man\n" >> $BASHRC

reportStep "Installation done... enjoy!"
reportStep "Close this terminal and open a new in order netkit to work."
reportStep "   ... or call 'source ~/.bashrc'"

