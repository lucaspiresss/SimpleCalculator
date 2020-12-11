pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        sh 'dotnet build'
        archiveArtifacts 'SimpleCalculator/bin/Debug/netcoreapp3.0/SimpleCalculator'
      }
    }

    stage('Test') {
      steps {
        sh 'dotnet test'
      }
    }

    stage('Package') {
      steps {
        sh 'tar -zcvf SimpeCalculator.tgz SimpleCalculator/bin/Debug/netcoreapp3.0/SimpleCalculator'
        archiveArtifacts 'SimpeCalculator.tgz'
      }
    }

    stage('Deploy') {
      steps {
        sh 'sshpass -o StrictHostKeyChecking=no -p appserverpassword scp SimpeCalculator.tgz root@192.168.30.12:/home/vagrant'
      }
    }

  }
}