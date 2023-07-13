FROM mcr.microsoft.com/mssql/server:2022-latest

USER root

COPY setup.sql setup.sql
COPY import-data.sh import-data.sh
COPY entrypoint.sh entrypoint.sh

ENV SA_PASSWORD CorrectHorseBatteryStapleFor$
ENV ACCEPT_EULA Y
ENV MSSQL_PID Express

RUN chmod +x entrypoint.sh

CMD /bin/bash ./entrypoint.sh