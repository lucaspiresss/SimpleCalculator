pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        sh 'dotnet build'
        archiveArtifacts(artifacts: 'SimpleCalculator/bin/Debug/netcoreapp3.0/SimpleCalculator', excludes: 'pipeline.log')
      }
    }

    stage('Test') {
      steps {
        sh 'dotnet test'
      }
    }

  }
}