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
      }
    }

  }
}