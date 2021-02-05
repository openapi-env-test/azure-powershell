#!/bin/bash -i

# This script is created to set up the env to generate Azure PowerShell modules based on swagger. 

# Installed required packages
sudo apt-get update \
    && sudo apt-get install -y curl \
    && curl -o- https://raw.githubusercontent.com/creationix/nvm/v0.33.11/install.sh | bash \
    && . /root/.bashrc \
    && nvm install 10.16.0 \
    && npm config set unsafe-perm true \
    && npm install -g autorest \
    && npm install -g dotnet-sdk-2.1

# Write $PATH to a file for later usage

echo "{\"envs\":{\"PATH\":\"$PATH\"}}" > $2