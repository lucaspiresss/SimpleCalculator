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
        sh 'ssh -o StrictHostKeyChecking=no root@192.168.30.12 \'echo $HOME\''
        sh 'sshpass -p appserverpassword scp SimpeCalculator.tgz root@192.168.30.12:/home/vagrant'
      }
    }

  }
}