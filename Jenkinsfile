pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        sh 'dotnet build'
        archiveArtifacts '/bin/Debug'
      }
    }

    stage('Test') {
      steps {
        sh 'dotnet test'
      }
    }

  }
}