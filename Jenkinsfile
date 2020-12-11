pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        echo 'Build project'
        sh 'dotnet build'
        echo 'Archieve binaries'
        archiveArtifacts 'SimpleCalculator/bin/Debug/netcoreapp3.0/SimpleCalculator'
      }
    }

    stage('Test') {
      steps {
        echo 'Run tests'
        sh 'dotnet test'
      }
    }

    stage('Package') {
      steps {
        echo 'Compress binaries'
        sh 'tar -zcvf SimpeCalculator.tgz SimpleCalculator/bin/Debug/netcoreapp3.0/SimpleCalculator'
        echo 'Archieve compressed file'
        archiveArtifacts 'SimpeCalculator.tgz'
      }
    }

    stage('Deploy') {
      steps {
        echo 'Connect to remote app server'
        sh 'sshpass -p appserverpassword ssh -o StrictHostKeyChecking=no root@192.168.30.12'
        echo 'Copy artifact to app server'
        sh 'sshpass -p appserverpassword scp SimpeCalculator.tgz root@192.168.30.12:/home/vagrant'
      }
    }

  }
}