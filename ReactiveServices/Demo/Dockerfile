FROM mono:latest
# Replace 192.168.59.103 with your RabbitMQ host address
ENV RABBITMQ_HOSTNAME 192.168.59.103
ADD ./bin/Debug/*.exe ./
ADD ./bin/Debug/*.dll ./
ADD ./bin/Debug/*.config ./
# Replace Demo.exe with your ReactiveServices application name
CMD [ "mono", "Demo.exe" ]