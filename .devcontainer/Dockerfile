FROM mcr.microsoft.com/devcontainers/dotnet:0-7.0

# Install SQL Tools: SQLPackage and sqlcmd
COPY mssql/installSQLtools.sh installSQLtools.sh
RUN bash ./installSQLtools.sh \
     && apt-get clean -y && rm -rf /var/lib/apt/lists/* /tmp/library-scripts

# install the preview version of dotnet
COPY dotnet/install-dotnet-preview.sh install-dotnet-preview.sh
RUN bash ./install-dotnet-preview.sh \
     && apt-get clean -y && rm -rf /var/lib/apt/lists/* /tmp/library-scripts     

RUN echo 'alias ls="ls -alF"' >> ~/.bashrc

# [Optional] Uncomment this section to install additional OS packages.
# RUN apt-get update && export DEBIAN_FRONTEND=noninteractive \
#     && apt-get -y install --no-install-recommends <your-package-list-here>

# [Optional] Uncomment this line to install global node packages.
# RUN su vscode -c "source /usr/local/share/nvm/nvm.sh && npm install -g <your-package-here>" 2>&1
