pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        sh 'dotnet build'
        archiveArtifacts '**'
      }
    }

    stage('Test') {
      steps {
        sh 'dotnet test'
      }
    }

  }
}